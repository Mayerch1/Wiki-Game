using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Collections.Concurrent;

namespace WikiGui
{
    public partial class Form1 : Form
    {
        /*-------------------------------------------------------------------------------*/

        //Internal variables

        #region Vars and Consts

        private static int _threadsToRun = 8;
        private static bool _isRunning = false;

        private static List<Thread> _threadList = new List<Thread>();

        private static List<bool> _workerFinished = new List<bool>();
        private static ConcurrentBag<HtmlList> _dic = new ConcurrentBag<HtmlList>();

        private Object _logLock = new object();
        /*-------------------------------------------------------------------------------*/

        //State variables reporting to UI
        private static int _hits;

        private static int _crawls;
        private static int _discards;
        private static int _loadErr;
        private static int _timeOuts;
        private static int _timeOutSkips;
        private static int _apiReq;
        private static int _formatErr;

        private static int _elapsedTime = 0;

        private static int _shortestDepth;
        private static string _shortestPath;

        private static string _zeroDepthBranch;
        private static string _oneDepthBranch;
        private static string _twoDepthBranch;

        private static int _refreshDelay = 150;

        public static List<string> _blackList = new List<string>();

        private ToolTip _myToolTip = new ToolTip();

        /*-------------------------------------------------------------------------------*/

        //Parameter, set with UI

        private static bool _ignoreYears = false;
        private static bool _disableApi = false;

        private string _targetPage = "Adolf_Hitler";
        private string _targetTitle = "Adolf Hitler";
        private string _language = "de";

        private int _maxDepth = 3;
        /*-------------------------------------------------------------------------------*/

        //User-Agent, for api-request
        private const string _userAgent = "This bot plays the /wiki/Wikipedia:Wiki_Game. It is open-source distributed through \"https://github.com/Mayerch1/Wiki-Game\" (ver. 1.2.0), so there's no control over who executes this request";

        //Parameter, hard coded
        private const string _constUrl = ".wikipedia.org/wiki/";

        private string _startUrl = "https://de.wikipedia.org/wiki/";

        private const string _startStr = "href=\"/wiki/", endStr = "\"";

        //on 32 768 output is interfering
        private const int _threadCount = 16384;

        //https://+_language+apiFrontUrl + requests + apiMidUrl + target
        private const string _apiFrontUrl = ".wikipedia.org//w/api.php?action=query&maxlag=5&format=json&prop=links&list=&titles=";

        private const int _maxRequestLenght = 50;
        private const string _apiMidUrl = "&pllimit=" + "50" + "&pltitles=";

        /*-------------------------------------------------------------------------------*/

        #endregion Vars and Consts

        /*-------------------------------------------------------------------------------*/

        #region Recursive Elements

        private int RekuSearch(string html, int depth, int maxDepth, ref WebClient client, ref string lastBranch)
        {
            using (client)
            {
                if (depth >= maxDepth)
                {
                    return 0;
                }
                else if (depth == (maxDepth - 2) && !_disableApi)
                {
                    bool apiRet = apiRequest(ref client, html, depth, ref lastBranch);
                    //run rest of routine return before next rekursive is called
                    return 0;
                }

                //download html-page
                string htmlCode;
                try
                {
                    htmlCode = client.DownloadString(html);
                }
                catch
                {
                    lock (_logLock)
                        logBox.AppendText("\nLoading error -> Skip.\n");
                    _loadErr++;
                    return 0;
                }

                int lastIndex = 0;

                //prevent a possible deadlock
                int cycles = 0;

                int Start;
                int End;

                //loop throug all links
                while ((Start = htmlCode.IndexOf(_startStr, lastIndex)) != -1 && cycles < 10000)
                {
                    //find location of next link
                    Start += _startStr.Length;
                    End = htmlCode.IndexOf(endStr, Start);

                    lastIndex = End + 1;
                    //HINT: possible deadlock
                    //cycles++;

                    //error in html format
                    if (End == -1)
                    {
                        _formatErr++;
                        return 0;
                    }

                    //get Link for next page
                    string nHtml = htmlCode.Substring(Start, End - Start);

                    switch (applyFilterToSubstr(nHtml, depth))
                    {
                        case (0):
                            return 1;

                        case (1):
                            continue;

                        case (2):
                            return 2;

                        case (3):
                            break;
                    }

                    //set strings to display current branch
                    //UI is updated in different thread
                    if (depth == 0)
                        _zeroDepthBranch = nHtml;
                    else if (depth == 1)
                        _oneDepthBranch = nHtml;
                    else if (depth == 2)
                        _twoDepthBranch = nHtml;

                    int rekReturn = RekuSearch("http://" + _language + ".wikipedia.org/wiki/" + nHtml, depth + 1, maxDepth, ref client, ref lastBranch);

                    int answerReturn = reactToReturn(rekReturn, ref nHtml, ref html, depth);
                    if (answerReturn == 1)
                        return 1;
                }
                return 0;
            }
        }

        //return 1 for filter hit
        //return 0 for hit on target
        //return 2 for hit on shortest target
        //return 3 for no hit
        private int applyFilterToSubstr(string nHtml, int depth)
        {
            //illegal pages

            if (nHtml.Contains(":") || nHtml.Contains("#"))
            {
                _discards++;
                return 1;
            }
            //year blacklist
            else if (_ignoreYears)
            {
                //if link consist only of digits
                if (Int32.TryParse(nHtml, out int tmp))
                {
                    _discards++;
                    return 1;
                }
            }
            //custom blacklist
            else if (_blackList.Count > 0)
            {
                bool toBreak = false;
                for (int i = 0; i < _blackList.Count; i++)
                {
                    //hit on blacklist
                    if (nHtml.Equals(_blackList[i]))
                    {
                        _discards++;
                        toBreak = true;
                        //break inner for
                        break;
                    }
                }
                //break outer for
                if (toBreak)
                    return 1;
            }

            //the next lines will open a new page, or return a success
            _crawls++;
            if (nHtml.Equals(_targetPage))
            {
                _hits++;
                //write hit into logbox
                lock (_logLock)
                    //TODO: uncomment
                    logBox.AppendText("\n" + _hits + ".\tDepth: " + (depth + 1) + " - " + nHtml + "/");
                if (depth < _shortestDepth)
                {
                    _shortestDepth = depth;
                    _shortestPath = nHtml;
                    return 2;
                }
                else
                    return 0;
            }
            return 3;
        }

        private bool apiRequest(ref WebClient client, string html, int depth, ref string lastBranch)
        {
            bool isHit = false;
            ConcurrentBag<HtmlList> apiList = new ConcurrentBag<HtmlList>();
            parseToDic(html, ref client, ref apiList);

            //add all Links in apiList as discard, sub hits later
            int deltaCrawls = apiList.Count;

            int deltaHits = 0;

            //get amount of requests needed
            int loopsNeeded = apiList.Count / _maxRequestLenght;
            if (apiList.Count % _maxRequestLenght > 0)
            {
                loopsNeeded++;
            }

            //lopps as much as needed, for max. 500 each loop
            for (int i = 0; i < loopsNeeded; i++)
            {
                //get api Request from Link-List
                string apiRequest = "http://" + _language + _apiFrontUrl;

                //take all, or first 500
                int apiLen = apiList.Count;
                for (int j = 0; (j < apiLen) && (j < _maxRequestLenght); j++)
                {
                    apiList.TryTake(out HtmlList result);
                    apiRequest += result.html + "|";
                    _crawls++;
                }

                //format rest of api request
                apiRequest = apiRequest.Remove(apiRequest.Length - 1);
                apiRequest += _apiMidUrl + _targetPage;

                string apiRet = "";
                int retry = 0;
                bool isBreak = false;
                //break when succesfull, unhandled fail, or 3 Timeouts
                while (true)
                {
                    try
                    {
                        apiRet = client.DownloadString(apiRequest);
                        break;
                    }
                    catch (WebException ex)
                    {
                        var err = ex.Response as System.Net.HttpWebResponse;
                        if (err.StatusCode == (System.Net.HttpStatusCode)429)
                        {
                            _timeOuts++;
                            //if timeout, retry 3 times
                            if (retry < 4)
                            {
                                lock (_logLock)
                                    logBox.AppendText("\nTo many Api request -> Timeout, Retry");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                lock (_logLock)
                                    logBox.AppendText("\nTo many Api request -> Timeout, Skip");
                                _timeOutSkips++;
                                Thread.Sleep(5000);
                                isBreak = true;
                                break;
                            }
                        }
                        else
                        {
                            lock (_logLock)
                                logBox.AppendText("\nApi error -> Skip.\n");
                            _loadErr++;
                            isBreak = true;
                            break;
                        }
                    }
                }
                //if no valid request after all, skip this request
                if (isBreak)
                    continue;

                _apiReq++;
                //search result for hits on target page

                deltaHits += evaluateApiRequest(ref apiRet, depth, ref lastBranch);
            }

            _crawls += deltaCrawls;

            return isHit;
        }

        private int evaluateApiRequest(ref string apiRet, int depth, ref string lastBranch)
        {
            int thisHits = 0;
            int targetIndex = 0;
            int lastIndex = 0;
            int firstIndex = 0;

            string thisBranch;

            while (true)
            {
                targetIndex = apiRet.IndexOf(_targetTitle, targetIndex + 1);
                if (targetIndex == -1)
                    break;

                lastIndex = apiRet.LastIndexOf("\",\"links\":[{\"ns\":0,\"title\":\"", targetIndex);
                if (lastIndex == -1)
                {
                    //if target is contained in invalid position
                    //iterate index and go to next loop
                    targetIndex++;
                    continue;
                }
                firstIndex = apiRet.LastIndexOf("\"", lastIndex - 1);

                thisBranch = apiRet.Substring(firstIndex + 1, lastIndex - firstIndex - 1);

                thisHits++;
                _hits++;
                //write hit into logbox
                lock (_logLock)
                {
                    //TODO: uncomment
                    logBox.AppendText("\n" + _hits + ".\tDepth: " + (depth + 2) + " - " + _targetPage + "/" + thisBranch + "/" + lastBranch);
                    if ((depth + 2) > 3)
                        logBox.AppendText("/...");
                    else
                        logBox.AppendText("//");
                }
                if (depth + 1 < _shortestDepth)
                {
                    _shortestDepth = depth + 1;
                    if ((depth + 2) > 3)
                        _shortestPath += "...->";
                    _shortestPath += lastBranch + "->" + thisBranch + "->" + _targetPage;
                }
            }
            return thisHits;
        }

        private int reactToReturn(int ret, ref string nHtml, ref string html, int depth)
        {
            if (ret >= 1)
            {
                //save the so far shortest solution
                if (ret == 2)
                {
                    _shortestPath += "/";
                    _shortestPath += nHtml;
                    _shortestPath += "/";
                    if (html != "")
                        _shortestPath += html.Substring(html.LastIndexOf('/')) + "/";
                }

                lock (_logLock)
                {
                    logBox.AppendText(nHtml);

                    if (html != "")
                        logBox.AppendText(html.Substring(html.LastIndexOf('/')) + "//");
                }
            }
            return 0;
        }

        #endregion Recursive Elements

        #region Event Section

        public Form1()
        {
            InitializeComponent();
            // this.DesktopLocation.Y = Properties.Settings.Default.posY;
            // this.Location.X = Properties.Settings.Default.posX;
            _maxDepth = Properties.Settings.Default.maxDepth;
            urlBox.Text = Properties.Settings.Default.startUrl;

            numericThreads.Maximum = _threadCount;

            //blackList = Properties.Settings.Default.BlackListSave.Cast<string>().ToList();

            //set all tooltips for main Form
            _myToolTip.SetToolTip(delayBox, "Low Values might impact CPU/GPU");
            _myToolTip.SetToolTip(delayLbl, "Low Values might impact CPU/GPU");
            _myToolTip.SetToolTip(threadLbl, "Only 1 Thread per Link on the first page can get a job");
            _myToolTip.SetToolTip(numericThreads, "Above 8, you can be detected as Ddos");

            _myToolTip.SetToolTip(countryBox, "Nation code of the wiki you want to crawl");
            _myToolTip.SetToolTip(urlBox, "Part of the Url, after the last /");

            _myToolTip.SetToolTip(targetBox, "Part of the Url, after the last /");
            _myToolTip.SetToolTip(depthLbl, "The nth hit must be already on the targetpage");
            _myToolTip.SetToolTip(depthBox, "The nth hit must be already on the targetpage");

            _myToolTip.SetToolTip(apiCheck, "Very slow, multiplies the bandwitdh use");
            _myToolTip.SetToolTip(apiReqLbl, "Shows succesfull Api requests");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.posX = this.Location.X;
            Properties.Settings.Default.posY = this.Location.Y;
            Properties.Settings.Default.maxDepth = _maxDepth;
            Properties.Settings.Default.startUrl = urlBox.Text;
            //for (int i = 0; i < blackList.Count; i++)
            //    Properties.Settings.Default.BlackListSave.Add(blackList[i]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                startBtn_Click(sender, e);
                logBox.Focus();
            }
        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        private void targetBox_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _refreshDelay = (int)delayBox.Value;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                for (int i = 0; i < _threadsToRun; i++)
                {
                    try
                    {
                        _threadList[i].Suspend();
                    }
                    catch { continue; }
                }
                timer.Stop();
                pauseBtn.Text = "Resume";
                startBtn.Text = "Paused";
                _isRunning = false;
            }
            else
            {
                timer.Start();
                for (int i = 0; i < _threadsToRun; i++)
                {
                    try
                    {
                        _threadList[i].Resume();
                    }
                    catch { continue; }
                }
                _isRunning = true;
                pauseBtn.Text = "Pause";
                startBtn.Text = "Working...";
            }
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _threadsToRun; i++)
            {
                if (_workerFinished[i] == false)
                {
                    try
                    {
                        _workerFinished[i] = true;
                        _threadList[i].Abort();
                    }
                    catch { continue; }
                }
            }

            allWorkersFinished();
        }

        //blackList button
        private void blackListBtn_Click(object sender, EventArgs e)
        {
            var contextPos = this.Location;
            contextPos.X += blackListBtn.Location.X;
            contextPos.Y += blackListBtn.Location.Y;

            blacklistContext.Show(contextPos);
        }

        private void customBlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blacklist window = new Blacklist();
            window.Location = this.Location;
            window.Show();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Text = "Working...";

            logBox.Clear();

            startBtn.Enabled = false;
            countryBox.Enabled = false;
            urlBox.Enabled = false;
            targetBox.Enabled = false;
            depthBox.Enabled = false;
            blackListBtn.Enabled = false;
            numericThreads.Enabled = false;
            apiCheck.Enabled = false;
            pauseBtn.Enabled = true;
            abortBtn.Enabled = true;

            _ignoreYears = yearsToolStrip.Checked;
            _disableApi = apiCheck.Checked;

            _language = countryBox.Text;
            _startUrl = "https://" + _language + _constUrl + urlBox.Text;
            _targetPage = targetBox.Text;
            _maxDepth = (int)depthBox.Value;

            _threadsToRun = (int)numericThreads.Value;
            ServicePointManager.DefaultConnectionLimit = 2 * _threadsToRun;

            _shortestDepth = _maxDepth + 1;
            _hits = _crawls = _discards = _loadErr = _formatErr = _apiReq = _timeOuts = _timeOutSkips = 0;
            _elapsedTime = 0;

            logBox.AppendText("\nValidating Target Page...");
            logBox.AppendText("\nGrabbing links...");
            logBox.AppendText("\nStarting threads...");

            timer.Start();

            //parse first side, to split into threads
            WebClient client = new WebClient();
            switch (getTargetPageTitle(ref client, _targetPage, ref _targetTitle))
            {
                case 1:
                    logBox.AppendText("\nNo connection to the Server!");
                    finished();
                    return;

                case 2:
                    logBox.AppendText("\nInvalid Target Page.\nMake sure to enter the last part of the link, not the name of the page");
                    finished();
                    return;
            }

            //return;
            logBox.Clear();
            parseToDic(_startUrl, ref client, ref _dic);

            //start all threads

            _workerFinished.Clear();
            //Thread[] workerThreads = new Thread[_threadsToRun];
            for (int i = 0; i < _threadsToRun; i++)
            {
                int x = i;

                try
                {
                    _threadList.Add(new Thread(() => threadRoutine(x)));

                    _threadList[i].IsBackground = true;

                    _workerFinished.Add(false);
                }
                catch (Exception)
                {
                    //no more threads are created
                    break;
                }
            }
            _isRunning = true;
            for (int i = 0; i < _threadsToRun; i++)
            {
                _threadList[i].Start();
            }

            //button1_Click(sender, e);
            //resumeBtn_Click(sender, e);

            //refresh the Ui-indicators
            await Delay();
        }

        private void randBtn_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string htmlCode;
            try
            {
                htmlCode = client.DownloadString("https://" + _language + ".wikipedia.org/w/api.php?action=query&format=json&list=random&rnlimit=1&rnnamespace=0");
            }
            catch
            {
                return;
            }

            //find title string in returned json
            int pageStart = htmlCode.IndexOf("\"title\":\"");
            pageStart += "\"title\":\"".Length;
            if (pageStart == -1)
                return;
            int pageEnd = htmlCode.IndexOf("\"", pageStart + 1);
            if (pageEnd == -1)
                return;

            string boxUrl = htmlCode.Substring(pageStart, pageEnd - pageStart);
            //sort out invalid unicode, just do another request
            if (boxUrl.Contains("\\u"))
            {
                randBtn_Click(sender, e);
                return;
            }
            urlBox.Text = boxUrl;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime++;
            timeLbl.Text = (_elapsedTime / 2).ToString() + ".";
            if (_elapsedTime % 2 != 0)
                timeLbl.Text += 5;
        }

        #endregion Event Section

        public int getTargetPageTitle(ref WebClient client, string page, ref string title)
        {
            string htmlCode;
            try
            {
                //request with api expression
                htmlCode = client.DownloadString("http://" + _language + ".wikipedia.org//w/api.php?action=query&format=json&prop=links&list=&titles=" + page);
            }
            catch
            {
                return 1;
            }

            //get subString, which contains the name of the target page
            string titleSeq = "\"from\":\"" + page + "\",\"to\":\"";
            int titlePos = htmlCode.IndexOf(titleSeq);
            if (titlePos == -1)
                return 2;
            titlePos += titleSeq.Length;
            int titleEnd = htmlCode.IndexOf("\"", titlePos);
            if (titleEnd == -1)
                return 2;

            //set global
            title = htmlCode.Substring(titlePos, titleEnd - titlePos);

            return 0;
        }

        public void parseToDic(string startUrl, ref WebClient client, ref ConcurrentBag<HtmlList> list)
        {
            using (client)
            {
                string htmlCode;
                try
                {
                    htmlCode = client.DownloadString(startUrl);
                }
                catch
                {
                    logBox.AppendText("\nLoading error -> Skip.\n");
                    _loadErr++;
                    return;
                }

                int lastIndex = 0;

                //prevent a possible deadlock
                int cycles = 0;

                int Start;
                int End;

                //loop throug all links
                while ((Start = htmlCode.IndexOf(_startStr, lastIndex)) != -1 && cycles < 10000)
                {
                    //find location of next link
                    Start += _startStr.Length;
                    End = htmlCode.IndexOf(endStr, Start);

                    lastIndex = End + 1;
                    //HINT: possible deadlock
                    //cycles++;

                    //error in html format
                    if (End == -1)
                    {
                        _formatErr++;
                        return;
                    }

                    //get Link for next page
                    string nHtml = htmlCode.Substring(Start, End - Start);

                    switch (applyFilterToSubstr(nHtml, 0))
                    {
                        case (0):
                            return;

                        case (1):
                            continue;

                        case (2):
                            return;

                        case (3):
                            break;
                    }
                    list.Add(new HtmlList { html = nHtml, isFree = true });
                }
            }
        }

        private void threadRoutine(int threadNum)
        {
            HtmlList entry;
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", _userAgent);

            while (true)
            {
                //take one link from joblist and mark is as taken
                entry = _dic.FirstOrDefault((var) => var.isFree);
                if (entry == null)
                    break;
                entry.isFree = false;

                //start rekursion
                _zeroDepthBranch = entry.html;

                int rekRet = RekuSearch("http://" + _language + ".wikipedia.org/wiki/" + entry.html, 1, _maxDepth, ref client, ref entry.html);

                string nHtml = entry.html;
                string html = "";
                reactToReturn(rekRet, ref nHtml, ref html, 0);
            }

            lock (_workerFinished)
            {
                _workerFinished[threadNum] = true;
                allWorkersFinished();
            }
        }

        private void allWorkersFinished()
        {
            foreach (var worker in _workerFinished)
            {
                if (!worker)
                    return;
            }

            finished();
        }

        private void finished()
        {
            _threadList.Clear();

            _isRunning = false;

            timer.Stop();

            //_reklim is part of _crawls
            int total = _crawls + _discards + _formatErr + _loadErr;

            logBox.AppendText("\n\nFinished, got " + _hits + " hit(s) on " + _targetPage + " starting from " + (_startUrl).Replace(" ", "_") + "\n");

            if (_shortestDepth + 1 <= _maxDepth)
                logBox.AppendText("The shortest and/or first solution took " + (_shortestDepth + 1) + " Steps: " + _shortestPath + "\n");
            logBox.AppendText("The process took " + (_elapsedTime / 2) + "s or " + (_elapsedTime / 2) / 60 + " minutes to finish\n");
            logBox.AppendText("\nA total of " + _apiReq + " Api request were made, with an average request rate of " + _apiReq / (_elapsedTime / 2) + " per second\n");
            logBox.AppendText("This rate forced " + _timeOuts + " timeouts, from which " + _timeOutSkips + " skipped the request\n");
            if (_timeOutSkips > 0)
                logBox.AppendText("\nDue to timeout - skips, it is possible that some hits are lost.To ensure complete solutions, it's recommended\n to re-run the Request with a lover thread count or without the api\n");

            logBox.AppendText("\n" + _crawls + " Page(s) where crawled\n");
            logBox.AppendText("From which " + (_crawls - _hits) + " (" + ((double)(_crawls - _hits) / (double)(_crawls) * 100).ToString("#.##") + "%) where discarded\n");

            logBox.AppendText(_loadErr + " Http Errors occured\n");

            startBtn.Text = "Start";
            pauseBtn.Text = "Pause";
            startBtn.Enabled = true;
            countryBox.Enabled = true;
            urlBox.Enabled = true;

            blackListBtn.Enabled = true;
            targetBox.Enabled = true;
            depthBox.Enabled = true;
            numericThreads.Enabled = true;
            apiCheck.Enabled = true;

            pauseBtn.Enabled = false;
            abortBtn.Enabled = false;
        }

        //Refresh Ui while rekursion is active
        //This prevents slowing the rekutsion down, bc of waits for UI
        private async Task Delay()
        {
            while (true)
            {
                crawlLbl.Text = _crawls.ToString();

                timeOutLbl.Text = _timeOuts.ToString();
                discardLbl.Text = _discards.ToString();
                apiReqLbl.Text = _apiReq.ToString();
                pathLbl.Text = _zeroDepthBranch;
                path2Lbl.Text = _oneDepthBranch;
                path3Lbl.Text = _twoDepthBranch;

                if (_refreshDelay == 0)
                    await Task.Delay(1);
                else
                    await Task.Delay(_refreshDelay);
            }
        }
    }

    public class HtmlList
    {
        public string html;
        public bool isFree;
    }
}