namespace WikiGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.crawlLbl = new System.Windows.Forms.Label();
            this.rekLimLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loadErrLbl = new System.Windows.Forms.Label();
            this.discardLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.path2Lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.path3Lbl = new System.Windows.Forms.Label();
            this.abortCheck = new System.Windows.Forms.CheckBox();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.depthLbl = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.path4Lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.delayLbl = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blackListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgButton = new System.Windows.Forms.Button();
            this.blacklistContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yearsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.customBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.httpErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleViolationlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekursionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortReasonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.blacklistContext.SuspendLayout();
            this.msgContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Location = new System.Drawing.Point(7, 551);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(61, 21);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(2, 2);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(172, 20);
            this.urlBox.TabIndex = 1;
            this.urlBox.Text = "Nacktschnecke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crawls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RekLim reached";
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(6, 44);
            this.logBox.Margin = new System.Windows.Forms.Padding(2);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(694, 494);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(178, 2);
            this.countryBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(56, 20);
            this.countryBox.TabIndex = 5;
            this.countryBox.Text = "de";
            this.countryBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // crawlLbl
            // 
            this.crawlLbl.AutoSize = true;
            this.crawlLbl.Location = new System.Drawing.Point(16, 16);
            this.crawlLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crawlLbl.Name = "crawlLbl";
            this.crawlLbl.Size = new System.Drawing.Size(13, 13);
            this.crawlLbl.TabIndex = 6;
            this.crawlLbl.Text = "0";
            // 
            // rekLimLbl
            // 
            this.rekLimLbl.AutoSize = true;
            this.rekLimLbl.Location = new System.Drawing.Point(21, 58);
            this.rekLimLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rekLimLbl.Name = "rekLimLbl";
            this.rekLimLbl.Size = new System.Drawing.Size(13, 13);
            this.rekLimLbl.TabIndex = 7;
            this.rekLimLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Http Error";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rule violation";
            // 
            // loadErrLbl
            // 
            this.loadErrLbl.AutoSize = true;
            this.loadErrLbl.Location = new System.Drawing.Point(22, 105);
            this.loadErrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadErrLbl.Name = "loadErrLbl";
            this.loadErrLbl.Size = new System.Drawing.Size(13, 13);
            this.loadErrLbl.TabIndex = 10;
            this.loadErrLbl.Text = "0";
            // 
            // discardLbl
            // 
            this.discardLbl.AutoSize = true;
            this.discardLbl.Location = new System.Drawing.Point(21, 159);
            this.discardLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discardLbl.Name = "discardLbl";
            this.discardLbl.Size = new System.Drawing.Size(13, 13);
            this.discardLbl.TabIndex = 11;
            this.discardLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Root";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pathLbl
            // 
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(20, 216);
            this.pathLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(17, 13);
            this.pathLbl.TabIndex = 13;
            this.pathLbl.Text = "//";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Branch";
            // 
            // path2Lbl
            // 
            this.path2Lbl.AutoSize = true;
            this.path2Lbl.Location = new System.Drawing.Point(20, 257);
            this.path2Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.path2Lbl.Name = "path2Lbl";
            this.path2Lbl.Size = new System.Drawing.Size(17, 13);
            this.path2Lbl.TabIndex = 15;
            this.path2Lbl.Text = "//";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sub Branch";
            // 
            // path3Lbl
            // 
            this.path3Lbl.AutoSize = true;
            this.path3Lbl.Location = new System.Drawing.Point(20, 304);
            this.path3Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.path3Lbl.Name = "path3Lbl";
            this.path3Lbl.Size = new System.Drawing.Size(17, 13);
            this.path3Lbl.TabIndex = 17;
            this.path3Lbl.Text = "//";
            // 
            // abortCheck
            // 
            this.abortCheck.AutoSize = true;
            this.abortCheck.Location = new System.Drawing.Point(238, 3);
            this.abortCheck.Margin = new System.Windows.Forms.Padding(2);
            this.abortCheck.Name = "abortCheck";
            this.abortCheck.Size = new System.Drawing.Size(80, 17);
            this.abortCheck.TabIndex = 18;
            this.abortCheck.Text = "only first Hit";
            this.abortCheck.UseVisualStyleBackColor = true;
            // 
            // targetBox
            // 
            this.targetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetBox.Location = new System.Drawing.Point(579, 0);
            this.targetBox.Margin = new System.Windows.Forms.Padding(2);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(274, 20);
            this.targetBox.TabIndex = 19;
            this.targetBox.Text = "Adolf_Hitler";
            // 
            // depthLbl
            // 
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(447, 5);
            this.depthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(59, 13);
            this.depthLbl.TabIndex = 20;
            this.depthLbl.Text = "max Steps:";
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(510, 0);
            this.depthBox.Margin = new System.Windows.Forms.Padding(2);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(65, 20);
            this.depthBox.TabIndex = 22;
            this.depthBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.path4Lbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.delayLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.delayBox);
            this.panel1.Controls.Add(this.crawlLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rekLimLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.loadErrLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.discardLbl);
            this.panel1.Controls.Add(this.path3Lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pathLbl);
            this.panel1.Controls.Add(this.path2Lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(705, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 493);
            this.panel1.TabIndex = 26;
            // 
            // path4Lbl
            // 
            this.path4Lbl.AutoSize = true;
            this.path4Lbl.Location = new System.Drawing.Point(22, 349);
            this.path4Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.path4Lbl.Name = "path4Lbl";
            this.path4Lbl.Size = new System.Drawing.Size(17, 13);
            this.path4Lbl.TabIndex = 29;
            this.path4Lbl.Text = "//";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Sub Sub Branch";
            // 
            // delayLbl
            // 
            this.delayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayLbl.AutoSize = true;
            this.delayLbl.Location = new System.Drawing.Point(8, 470);
            this.delayLbl.Name = "delayLbl";
            this.delayLbl.Size = new System.Drawing.Size(96, 13);
            this.delayLbl.TabIndex = 27;
            this.delayLbl.Text = "Refresh Delay (ms)";
            // 
            // delayBox
            // 
            this.delayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayBox.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.delayBox.Location = new System.Drawing.Point(107, 468);
            this.delayBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(51, 20);
            this.delayBox.TabIndex = 26;
            this.delayBox.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.delayBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.blackListButton);
            this.panel2.Controls.Add(this.urlBox);
            this.panel2.Controls.Add(this.countryBox);
            this.panel2.Controls.Add(this.targetBox);
            this.panel2.Controls.Add(this.depthBox);
            this.panel2.Controls.Add(this.depthLbl);
            this.panel2.Controls.Add(this.abortCheck);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 26);
            this.panel2.TabIndex = 27;
            // 
            // blackListButton
            // 
            this.blackListButton.Location = new System.Drawing.Point(367, 0);
            this.blackListButton.Name = "blackListButton";
            this.blackListButton.Size = new System.Drawing.Size(75, 23);
            this.blackListButton.TabIndex = 23;
            this.blackListButton.Text = "Blacklist...";
            this.blackListButton.UseVisualStyleBackColor = true;
            this.blackListButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(785, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Abort and Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // msgButton
            // 
            this.msgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.msgButton.Location = new System.Drawing.Point(629, 548);
            this.msgButton.Name = "msgButton";
            this.msgButton.Size = new System.Drawing.Size(71, 23);
            this.msgButton.TabIndex = 29;
            this.msgButton.Text = "Messages...";
            this.msgButton.UseVisualStyleBackColor = true;
            this.msgButton.Click += new System.EventHandler(this.msgButton_Click);
            // 
            // blacklistContext
            // 
            this.blacklistContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearsToolStrip,
            this.customBlacklistToolStripMenuItem});
            this.blacklistContext.Name = "blacklistContext";
            this.blacklistContext.Size = new System.Drawing.Size(172, 48);
            // 
            // yearsToolStrip
            // 
            this.yearsToolStrip.AutoToolTip = true;
            this.yearsToolStrip.CheckOnClick = true;
            this.yearsToolStrip.Name = "yearsToolStrip";
            this.yearsToolStrip.Size = new System.Drawing.Size(171, 22);
            this.yearsToolStrip.Text = "Years";
            this.yearsToolStrip.ToolTipText = "Add pages of years to the blacklist";
            // 
            // customBlacklistToolStripMenuItem
            // 
            this.customBlacklistToolStripMenuItem.Name = "customBlacklistToolStripMenuItem";
            this.customBlacklistToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.customBlacklistToolStripMenuItem.Text = "Custom Blacklist...";
            this.customBlacklistToolStripMenuItem.Click += new System.EventHandler(this.customBlacklistToolStripMenuItem_Click);
            // 
            // msgContext
            // 
            this.msgContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpErrorToolStripMenuItem,
            this.ruleViolationlToolStripMenuItem,
            this.rekursionStatusToolStripMenuItem,
            this.abortReasonsToolStripMenuItem});
            this.msgContext.Name = "msgContext";
            this.msgContext.Size = new System.Drawing.Size(193, 92);
            // 
            // httpErrorToolStripMenuItem
            // 
            this.httpErrorToolStripMenuItem.CheckOnClick = true;
            this.httpErrorToolStripMenuItem.Name = "httpErrorToolStripMenuItem";
            this.httpErrorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.httpErrorToolStripMenuItem.Text = "show Http Errors";
            this.httpErrorToolStripMenuItem.Click += new System.EventHandler(this.httpErrorToolStripMenuItem_Click);
            // 
            // ruleViolationlToolStripMenuItem
            // 
            this.ruleViolationlToolStripMenuItem.AutoToolTip = true;
            this.ruleViolationlToolStripMenuItem.CheckOnClick = true;
            this.ruleViolationlToolStripMenuItem.Name = "ruleViolationlToolStripMenuItem";
            this.ruleViolationlToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ruleViolationlToolStripMenuItem.Text = "show Rule Violations";
            this.ruleViolationlToolStripMenuItem.ToolTipText = "heavy impact on performance";
            this.ruleViolationlToolStripMenuItem.Click += new System.EventHandler(this.ruleViolationlToolStripMenuItem_Click);
            // 
            // rekursionStatusToolStripMenuItem
            // 
            this.rekursionStatusToolStripMenuItem.AutoToolTip = true;
            this.rekursionStatusToolStripMenuItem.CheckOnClick = true;
            this.rekursionStatusToolStripMenuItem.Name = "rekursionStatusToolStripMenuItem";
            this.rekursionStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rekursionStatusToolStripMenuItem.Text = "show Rekursion Status";
            this.rekursionStatusToolStripMenuItem.ToolTipText = "heavy impact on performance";
            this.rekursionStatusToolStripMenuItem.Click += new System.EventHandler(this.rekursionStatusToolStripMenuItem_Click);
            // 
            // abortReasonsToolStripMenuItem
            // 
            this.abortReasonsToolStripMenuItem.AutoToolTip = true;
            this.abortReasonsToolStripMenuItem.CheckOnClick = true;
            this.abortReasonsToolStripMenuItem.Name = "abortReasonsToolStripMenuItem";
            this.abortReasonsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.abortReasonsToolStripMenuItem.Text = "show Abort Reasons";
            this.abortReasonsToolStripMenuItem.ToolTipText = "heavy impact on performance";
            this.abortReasonsToolStripMenuItem.Click += new System.EventHandler(this.abortReasonsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 583);
            this.Controls.Add(this.msgButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.startBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(691, 520);
            this.Name = "Form1";
            this.Text = "The Wiki-Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.blacklistContext.ResumeLayout(false);
            this.msgContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label crawlLbl;
        private System.Windows.Forms.Label rekLimLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loadErrLbl;
        private System.Windows.Forms.Label discardLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label path2Lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label path3Lbl;
        private System.Windows.Forms.CheckBox abortCheck;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label delayLbl;
        private System.Windows.Forms.NumericUpDown delayBox;
        private System.Windows.Forms.Label path4Lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button blackListButton;
        private System.Windows.Forms.Button msgButton;
        private System.Windows.Forms.ContextMenuStrip blacklistContext;
        private System.Windows.Forms.ToolStripMenuItem yearsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem customBlacklistToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip msgContext;
        private System.Windows.Forms.ToolStripMenuItem httpErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleViolationlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortReasonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekursionStatusToolStripMenuItem;
    }
}

