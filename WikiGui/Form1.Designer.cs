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
            this.apiReqLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeOutLbl = new System.Windows.Forms.Label();
            this.discardLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.path2Lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.path3Lbl = new System.Windows.Forms.Label();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.depthLbl = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delayLbl = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apiCheck = new System.Windows.Forms.CheckBox();
            this.randBtn = new System.Windows.Forms.Button();
            this.blackListButton = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.blacklistContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yearsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.customBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericThreads = new System.Windows.Forms.NumericUpDown();
            this.threadLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.blacklistContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Location = new System.Drawing.Point(7, 600);
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
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Api Requests";
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
            this.logBox.Size = new System.Drawing.Size(773, 543);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(204, 2);
            this.countryBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(56, 20);
            this.countryBox.TabIndex = 5;
            this.countryBox.Text = "de";
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
            // apiReqLbl
            // 
            this.apiReqLbl.AutoSize = true;
            this.apiReqLbl.Location = new System.Drawing.Point(21, 58);
            this.apiReqLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apiReqLbl.Name = "apiReqLbl";
            this.apiReqLbl.Size = new System.Drawing.Size(13, 13);
            this.apiReqLbl.TabIndex = 7;
            this.apiReqLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Api-Timeouts";
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
            // timeOutLbl
            // 
            this.timeOutLbl.AutoSize = true;
            this.timeOutLbl.Location = new System.Drawing.Point(22, 105);
            this.timeOutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeOutLbl.Name = "timeOutLbl";
            this.timeOutLbl.Size = new System.Drawing.Size(13, 13);
            this.timeOutLbl.TabIndex = 10;
            this.timeOutLbl.Text = "0";
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
            // targetBox
            // 
            this.targetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetBox.Location = new System.Drawing.Point(615, 0);
            this.targetBox.Margin = new System.Windows.Forms.Padding(2);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(317, 20);
            this.targetBox.TabIndex = 19;
            this.targetBox.Text = "Adolf_Hitler";
            // 
            // depthLbl
            // 
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(482, 4);
            this.depthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(59, 13);
            this.depthLbl.TabIndex = 20;
            this.depthLbl.Text = "max Steps:";
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(545, 0);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.delayLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.delayBox);
            this.panel1.Controls.Add(this.crawlLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.apiReqLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timeOutLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.discardLbl);
            this.panel1.Controls.Add(this.path3Lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pathLbl);
            this.panel1.Controls.Add(this.path2Lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(784, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 542);
            this.panel1.TabIndex = 26;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(22, 483);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(13, 13);
            this.timeLbl.TabIndex = 31;
            this.timeLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Elapsed Seconds";
            // 
            // delayLbl
            // 
            this.delayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayLbl.AutoSize = true;
            this.delayLbl.Location = new System.Drawing.Point(8, 519);
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
            this.delayBox.Location = new System.Drawing.Point(107, 517);
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
            this.panel2.Controls.Add(this.apiCheck);
            this.panel2.Controls.Add(this.randBtn);
            this.panel2.Controls.Add(this.blackListButton);
            this.panel2.Controls.Add(this.urlBox);
            this.panel2.Controls.Add(this.countryBox);
            this.panel2.Controls.Add(this.targetBox);
            this.panel2.Controls.Add(this.depthBox);
            this.panel2.Controls.Add(this.depthLbl);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 26);
            this.panel2.TabIndex = 27;
            // 
            // apiCheck
            // 
            this.apiCheck.AutoSize = true;
            this.apiCheck.Location = new System.Drawing.Point(265, 4);
            this.apiCheck.Name = "apiCheck";
            this.apiCheck.Size = new System.Drawing.Size(79, 17);
            this.apiCheck.TabIndex = 24;
            this.apiCheck.Text = "disable API";
            this.apiCheck.UseVisualStyleBackColor = true;
            // 
            // randBtn
            // 
            this.randBtn.BackgroundImage = global::WikiGui.Properties.Resources.shuffle;
            this.randBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randBtn.Location = new System.Drawing.Point(179, 2);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(20, 20);
            this.randBtn.TabIndex = 32;
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.Click += new System.EventHandler(this.randBtn_Click);
            // 
            // blackListButton
            // 
            this.blackListButton.Location = new System.Drawing.Point(402, 0);
            this.blackListButton.Name = "blackListButton";
            this.blackListButton.Size = new System.Drawing.Size(75, 23);
            this.blackListButton.TabIndex = 23;
            this.blackListButton.Text = "Blacklist...";
            this.blackListButton.UseVisualStyleBackColor = true;
            this.blackListButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(816, 596);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(61, 21);
            this.stopBtn.TabIndex = 28;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // blacklistContext
            // 
            this.blacklistContext.ImageScalingSize = new System.Drawing.Size(28, 28);
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
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numericThreads
            // 
            this.numericThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericThreads.Location = new System.Drawing.Point(732, 597);
            this.numericThreads.Margin = new System.Windows.Forms.Padding(2);
            this.numericThreads.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numericThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThreads.Name = "numericThreads";
            this.numericThreads.Size = new System.Drawing.Size(47, 20);
            this.numericThreads.TabIndex = 30;
            this.numericThreads.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // threadLbl
            // 
            this.threadLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.threadLbl.AutoSize = true;
            this.threadLbl.Location = new System.Drawing.Point(633, 600);
            this.threadLbl.Name = "threadLbl";
            this.threadLbl.Size = new System.Drawing.Size(94, 13);
            this.threadLbl.TabIndex = 31;
            this.threadLbl.Text = "Number of threads";
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Location = new System.Drawing.Point(883, 596);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(61, 21);
            this.resetBtn.TabIndex = 32;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 624);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.threadLbl);
            this.Controls.Add(this.numericThreads);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.startBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(733, 523);
            this.Name = "Form1";
            this.Text = "The Wiki-Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.blacklistContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label crawlLbl;
        private System.Windows.Forms.Label apiReqLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeOutLbl;
        private System.Windows.Forms.Label discardLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label path2Lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label path3Lbl;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label delayLbl;
        private System.Windows.Forms.NumericUpDown delayBox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button blackListButton;
        private System.Windows.Forms.ContextMenuStrip blacklistContext;
        private System.Windows.Forms.ToolStripMenuItem yearsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem customBlacklistToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericThreads;
        private System.Windows.Forms.Label threadLbl;
        private System.Windows.Forms.CheckBox apiCheck;
        private System.Windows.Forms.Button randBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

