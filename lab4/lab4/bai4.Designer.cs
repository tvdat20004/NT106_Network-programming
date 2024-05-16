namespace lab4
{
    partial class bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai4));
            this.browserView1 = new DotNetBrowser.WinForms.BrowserView();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.downHTMLButton = new System.Windows.Forms.Button();
            this.fullSrcDownloadButton = new System.Windows.Forms.Button();
            this.showHeaderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browserView1
            // 
            this.browserView1.AllowDrop = true;
            this.browserView1.AutoScroll = true;
            this.browserView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.browserView1.Location = new System.Drawing.Point(34, 133);
            this.browserView1.Name = "browserView1";
            this.browserView1.Size = new System.Drawing.Size(1485, 854);
            this.browserView1.TabIndex = 0;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.forwardButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Location = new System.Drawing.Point(127, 29);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(59, 63);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(44, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(59, 63);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(306, 45);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(1024, 40);
            this.urlTextBox.TabIndex = 4;
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loadButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(1392, 32);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(127, 63);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(211, 29);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(59, 63);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = " ";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // downHTMLButton
            // 
            this.downHTMLButton.BackColor = System.Drawing.SystemColors.Info;
            this.downHTMLButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.downHTMLButton.Location = new System.Drawing.Point(34, 993);
            this.downHTMLButton.Name = "downHTMLButton";
            this.downHTMLButton.Size = new System.Drawing.Size(207, 37);
            this.downHTMLButton.TabIndex = 7;
            this.downHTMLButton.Text = "Download HTML";
            this.downHTMLButton.UseVisualStyleBackColor = false;
            this.downHTMLButton.Click += new System.EventHandler(this.downHTMLButton_Click);
            // 
            // fullSrcDownloadButton
            // 
            this.fullSrcDownloadButton.BackColor = System.Drawing.SystemColors.Info;
            this.fullSrcDownloadButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.fullSrcDownloadButton.Location = new System.Drawing.Point(256, 993);
            this.fullSrcDownloadButton.Name = "fullSrcDownloadButton";
            this.fullSrcDownloadButton.Size = new System.Drawing.Size(272, 37);
            this.fullSrcDownloadButton.TabIndex = 8;
            this.fullSrcDownloadButton.Text = "Download full source";
            this.fullSrcDownloadButton.UseVisualStyleBackColor = false;
            this.fullSrcDownloadButton.Click += new System.EventHandler(this.fullSrcDownloadButton_Click);
            // 
            // showHeaderButton
            // 
            this.showHeaderButton.BackColor = System.Drawing.SystemColors.Info;
            this.showHeaderButton.Font = new System.Drawing.Font("Consolas", 10F);
            this.showHeaderButton.Location = new System.Drawing.Point(547, 993);
            this.showHeaderButton.Name = "showHeaderButton";
            this.showHeaderButton.Size = new System.Drawing.Size(192, 37);
            this.showHeaderButton.TabIndex = 9;
            this.showHeaderButton.Text = "Show headers";
            this.showHeaderButton.UseVisualStyleBackColor = false;
            this.showHeaderButton.Click += new System.EventHandler(this.showHeaderButton_Click);
            // 
            // bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 1059);
            this.Controls.Add(this.showHeaderButton);
            this.Controls.Add(this.fullSrcDownloadButton);
            this.Controls.Add(this.downHTMLButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.browserView1);
            this.Name = "bai4";
            this.Text = "bai4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bai2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetBrowser.WinForms.BrowserView browserView1;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button downHTMLButton;
        private System.Windows.Forms.Button fullSrcDownloadButton;
        private System.Windows.Forms.Button showHeaderButton;
    }
}