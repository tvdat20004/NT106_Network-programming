namespace lab4
{
    partial class bai2
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rawHTML = new System.Windows.Forms.Button();
            this.renderHTML = new System.Windows.Forms.Button();
            this.htmlTextBox = new System.Windows.Forms.RichTextBox();
            this.browserView1 = new DotNetBrowser.WinForms.BrowserView();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(225, 54);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(1256, 40);
            this.urlTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "User-agent";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/123.0.0.0 Safari/537.36",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like" +
                " Gecko) Version/17.3.1 Safari/605.1.1",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/123.0.0.0 Safari/537.36 Edg/123.0.0.0",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/122.0.0.0 Safari/537.36 OPR/108.0.0.",
            "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML," +
                " like Gecko) Chrome/123.0.0.0 Mobile Safari/537.36",
            "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3 like Mac OS X) AppleWebKit/602.1.50 (KHTM" +
                "L, like Gecko) CriOS/123.0.0.0 Mobile/14E5239e Safari/602.1",
            "Mozilla/5.0 (Android 4.4; Mobile; rv:41.0) Gecko/41.0 Firefox/41.0",
            "Mozilla/5.0 (Linux; Android 5.0; SAMSUNG SM-G900F Build/LRX21T) AppleWebKit/537.3" +
                "6 (KHTML, like Gecko) SamsungBrowser/2.1 Chrome/34.0.1847.76 Mobile Safari/537.3" +
                "6",
            "Mozilla/5.0 (Linux; U; Android 4.4.2; en-US; ALCATEL ONE TOUCH 7041D Build/KOT49H" +
                ") AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 UCBrowser/10.7.0.636 U3/0.8" +
                ".0 Mobile Safari/534.30"});
            this.comboBox1.Location = new System.Drawing.Point(225, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(804, 36);
            this.comboBox1.TabIndex = 7;
            // 
            // rawHTML
            // 
            this.rawHTML.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rawHTML.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawHTML.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rawHTML.Location = new System.Drawing.Point(1077, 130);
            this.rawHTML.Name = "rawHTML";
            this.rawHTML.Size = new System.Drawing.Size(179, 50);
            this.rawHTML.TabIndex = 8;
            this.rawHTML.Text = "Raw HTML";
            this.rawHTML.UseVisualStyleBackColor = false;
            this.rawHTML.Click += new System.EventHandler(this.rawHTML_Click);
            // 
            // renderHTML
            // 
            this.renderHTML.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.renderHTML.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderHTML.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renderHTML.Location = new System.Drawing.Point(1281, 130);
            this.renderHTML.Name = "renderHTML";
            this.renderHTML.Size = new System.Drawing.Size(200, 51);
            this.renderHTML.TabIndex = 9;
            this.renderHTML.Text = "Render HTML";
            this.renderHTML.UseVisualStyleBackColor = false;
            this.renderHTML.Click += new System.EventHandler(this.renderHTML_Click);
            // 
            // htmlTextBox
            // 
            this.htmlTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlTextBox.Location = new System.Drawing.Point(60, 218);
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.Size = new System.Drawing.Size(1421, 734);
            this.htmlTextBox.TabIndex = 10;
            this.htmlTextBox.Text = "";
            // 
            // browserView1
            // 
            this.browserView1.AllowDrop = true;
            this.browserView1.Location = new System.Drawing.Point(60, 218);
            this.browserView1.Name = "browserView1";
            this.browserView1.Size = new System.Drawing.Size(1421, 734);
            this.browserView1.TabIndex = 11;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 985);
            this.Controls.Add(this.browserView1);
            this.Controls.Add(this.htmlTextBox);
            this.Controls.Add(this.renderHTML);
            this.Controls.Add(this.rawHTML);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label1);
            this.Name = "bai2";
            this.Text = "bai2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bai2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button rawHTML;
        private System.Windows.Forms.Button renderHTML;
        private System.Windows.Forms.RichTextBox htmlTextBox;
        private DotNetBrowser.WinForms.BrowserView browserView1;
    }
}