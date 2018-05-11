namespace WikiGui
{
    partial class Blacklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blacklist));
            this.closeBtn = new System.Windows.Forms.Button();
            this.entryBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.rmButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.donateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(826, 544);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // entryBox
            // 
            this.entryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entryBox.Location = new System.Drawing.Point(13, 512);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(280, 20);
            this.entryBox.TabIndex = 2;
            this.entryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(299, 512);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // rmButton
            // 
            this.rmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rmButton.Location = new System.Drawing.Point(826, 512);
            this.rmButton.Name = "rmButton";
            this.rmButton.Size = new System.Drawing.Size(75, 23);
            this.rmButton.TabIndex = 4;
            this.rmButton.Text = "Remove";
            this.rmButton.UseVisualStyleBackColor = true;
            this.rmButton.Click += new System.EventHandler(this.rmButton_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(889, 485);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 5;
            // 
            // donateBtn
            // 
            this.donateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.donateBtn.BackgroundImage = global::WikiGui.Properties.Resources.paypal;
            this.donateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donateBtn.Location = new System.Drawing.Point(12, 538);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(35, 35);
            this.donateBtn.TabIndex = 6;
            this.donateBtn.UseVisualStyleBackColor = true;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // Blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 579);
            this.Controls.Add(this.donateBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.rmButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.entryBox);
            this.Controls.Add(this.closeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(478, 116);
            this.Name = "Blacklist";
            this.Text = "BlackListEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox entryBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button rmButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button donateBtn;
    }
}