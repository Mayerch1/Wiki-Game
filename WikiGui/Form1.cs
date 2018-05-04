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

namespace WikiGui
{
    public partial class Form1 : Form
    {
        public int RekuSearch(string html, int depth, int maxDepth)
        {
            using (_client)
            {
                if (_debug_lvl2)
                    logBox.AppendText("Curr Depth: " + (depth) + "\n");
                if (depth >= maxDepth)
                {
                    if (_debug_lvl2)
                        logBox.AppendText("max rek lvl reached (" + depth + ")\n");
                    _rekLim++;
                    return 0;
                }

                //download html-page
                string htmlCode;
                try
                {
                    htmlCode = _client.DownloadString(html);
                }
                catch
                {
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
                while ((Start = htmlCode.IndexOf(startStr, lastIndex)) != -1 && cycles < 1000)
                {
                    //find location of next link
                    Start += startStr.Length;
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

                    //illegal pages
                    //TODO: better rule
                    if (nHtml.Contains(":"))
                    {
                        if (_debug_lvl3)
                            logBox.AppendText("Skipped, due to illegal link\n");
                        _discards++;
                        continue;
                    }
                    //blacklist
                    else if (ignoreDates)
                    {
                        //TODO: ignore dates
                        // /wiki/9_April
                    }
                    else if (ignoreYears)
                    {
                        if (Int32.TryParse(nHtml, out int tmp))
                        {
                            if (_debug_lvl3)
                                logBox.AppendText("Skipped, due to illegal link\n");
                            _discards++;
                            continue;
                        }
                    }
                    else if (isBlackList == true)
                    {
                        bool toBreak = false;
                        for (int i = 0; i < blackList.Length; i++)
                        {
                            if (nHtml.Contains(blackList[i]))
                            {
                                if (_debug_lvl1)
                                    logBox.AppendText("Skipped, due to illegal link\n");
                                _discards++;
                                toBreak = true;
                                break;
                            }
                        }
                        if (toBreak)
                            continue;
                    }

                    //the next lines will open a new page, or return a success
                    _crawls++;
                    if (nHtml.Equals(_targetPage))
                    {
                        _hits++;
                        logBox.AppendText("\n" + _hits + ".\tDepth: " + (depth + 1) + " - " + nHtml + "/");
                        if (depth < _shortestDepth)
                        {
                            _shortestDepth = depth;
                            _shortestPath = nHtml;
                            return 2;
                        }
                        else
                            return 1;
                    }

                    //set strings to display current branch
                    //UI is updated in other thread
                    if (depth == 0)
                        _zeroDepthBranch = nHtml;
                    else if (depth == 1)
                        _oneDepthBranch = nHtml;
                    else if (depth == 2)
                        _twoDepthBranch = nHtml;
                    else if (depth == 3)
                        _threeDepthBranch = nHtml;

                    int rekReturn = RekuSearch("http://" + _language + ".wikipedia.org/wiki/" + nHtml, depth + 1, maxDepth);
                    if (rekReturn >= 1)
                    {
                        //save the so far shortest solution
                        if (rekReturn == 2)
                        {
                            _shortestPath += "/";
                            _shortestPath += nHtml;
                            _shortestPath += "/";
                            _shortestPath += html.Substring(html.LastIndexOf('/')) + "/";
                        }

                        logBox.AppendText(nHtml);

                        //may cut path for higher depths than 3
                        if (_abort == true)
                        {
                            logBox.AppendText("/");
                            return 1;
                        }

                        logBox.AppendText(html.Substring(html.LastIndexOf('/')) + "//");
                    }
                    else
                    {
                        if (_debug_lvl2)
                            logBox.AppendText("Dead end for this depht: " + nHtml + "\n");
                    }
                }
                return 0;
            }
        }

        public void finished()
        {
            //_reklim is part of _crawls
            int total = _crawls + _discards + _formatErr + _loadErr;

            logBox.AppendText("\n\nFinished, got " + _hits + " hit(s) on " + _targetPage + " starting from " + startUrl);
            logBox.AppendText("\nThe shortest and/or first solution took " + (_shortestDepth + 1) + " Steps: " + _shortestPath + "\n\n");
            logBox.AppendText(_crawls + " Page(s) where crawled\n");
            logBox.AppendText("From wich " + _rekLim + " Links where discarded for reaching the rekursion limit (" + ((double)_rekLim / (double)(total) * 100).ToString("#.##") + "%)");
            logBox.AppendText("\nAn additional " + _discards + " Links where discarded due to rule violation (" + ((double)_discards / (double)(total) * 100).ToString("#.##") + "%)\n");
            logBox.AppendText(_loadErr + " Http Errors occured\n");
            logBox.AppendText(_formatErr + " format Errors in the html-file occured\n");

            if (_abort == true)
                logBox.AppendText("\nNot finished rekursion paths can cause total percentages below 100%!");

            startBtn.Text = "Start";
            startBtn.Enabled = true;
            countryBox.Enabled = true;
            urlBox.Enabled = true;
            abortCheck.Enabled = true;
            targetBox.Enabled = true;
            depthBox.Enabled = true;
        }

        /*-------------------------------------------------------------------------------*/

        //State variables reporting to UI
        private static int _hits;

        private static int _crawls;
        private static int _discards;
        private static int _loadErr;
        private static int _rekLim;
        private static int _formatErr;

        private static int _shortestDepth;
        private static string _shortestPath;

        private static string _zeroDepthBranch;
        private static string _oneDepthBranch;
        private static string _twoDepthBranch;
        private static string _threeDepthBranch;

        private static int _refreshDelay = 200;

        private ToolTip myToolTip = new ToolTip();

        /*-------------------------------------------------------------------------------*/

        //Internal variables
        private WebClient _client = new WebClient();

        /*-------------------------------------------------------------------------------*/

        //Parameter, set with UI
        //abort after one hit
        private bool _abort = false;

        private static bool ignoreYears = false;

        private string _targetPage = "Adolf_Hitler";
        private string _language = "de";

        private int _maxDepth = 3;
        /*-------------------------------------------------------------------------------*/

        //Parameter, hard coded
        private const string _constUrl = ".wikipedia.org/wiki/";

        private string startUrl = "https://de.wikipedia.org/wiki/";

        private const string startStr = "href=\"/wiki/", endStr = "\"";

        private const bool _debug_lvl1 = false;
        private const bool _debug_lvl2 = false;
        private const bool _debug_lvl3 = false;

        /*-------------------------------------------------------------------------------*/

        //TODO: implement
        private const bool ignoreDates = false; //not impemented yet

        private const bool ignoreNations = false;
        private const bool isBlackList = false;
        private static string[] blackList = { "Deutschland", "Niederlande", "Zweiter_Weltkrieg" };
        /*-------------------------------------------------------------------------------*/

        public Form1()
        {
            InitializeComponent();

            //set all tooltips for main Form
            myToolTip.SetToolTip(delayBox, "Low Values might impact CPU/GPU");
            myToolTip.SetToolTip(delayLbl, "Low Values might impact CPU/GPU");
            myToolTip.SetToolTip(abortCheck, "Break search after the first hit");
            myToolTip.SetToolTip(countryBox, "Nation code of the wiki you want to crawl");
            myToolTip.SetToolTip(urlBox, "Last Url-part of the start page");

            myToolTip.SetToolTip(targetBox, "Last Url-part of the start page");
            myToolTip.SetToolTip(depthLbl, "The nth hit must be already on your target");
            myToolTip.SetToolTip(depthBox, "The nth hit must be already on your target");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _refreshDelay = (int)delayBox.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RekuSearch(startUrl, 0, _maxDepth);
            finished();
            startBtn.Text = "Reset";
            startBtn.Enabled = true;
        }

        //Refresh Ui while rekursion is active
        //This prevents slowing the rekutsion down, bc of waits for UI
        private async Task Delay()
        {
            while (true)
            {
                crawlLbl.Text = _crawls.ToString();
                rekLimLbl.Text = _rekLim.ToString();
                loadErrLbl.Text = _loadErr.ToString();
                discardLbl.Text = _discards.ToString();

                pathLbl.Text = _zeroDepthBranch;
                path2Lbl.Text = _oneDepthBranch;
                path3Lbl.Text = _twoDepthBranch;
                path4Lbl.Text = _threeDepthBranch;
                await Task.Delay(_refreshDelay);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "Reset")
            {
                startBtn.Text = "Start";
                backgroundWorker1.CancelAsync();

                return;
            }
            else
            {
                startBtn.Text = "Working...";

                logBox.Clear();

                startBtn.Enabled = false;
                countryBox.Enabled = false;
                urlBox.Enabled = false;
                abortCheck.Enabled = false;
                targetBox.Enabled = false;
                depthBox.Enabled = false;
                dateCheck.Enabled = false;

                _abort = abortCheck.Checked;
                ignoreYears = dateCheck.Checked;

                _language = countryBox.Text;
                startUrl = "https://" + _language + _constUrl + urlBox.Text;
                _targetPage = targetBox.Text;
                _maxDepth = (int)depthBox.Value;

                _shortestDepth = _maxDepth + 1;
                _hits = _crawls = _discards = _loadErr = _rekLim = _formatErr = 0;

                backgroundWorker1.RunWorkerAsync();

                await Delay();
            }
        }
    }
}