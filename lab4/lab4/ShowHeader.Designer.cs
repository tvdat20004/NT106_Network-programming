namespace lab4
{
    partial class ShowHeader
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
            this.requestHeaders = new System.Windows.Forms.ListView();
            this.responseHeaders = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requestHeaders
            // 
            this.requestHeaders.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestHeaders.HideSelection = false;
            this.requestHeaders.Location = new System.Drawing.Point(77, 88);
            this.requestHeaders.Name = "requestHeaders";
            this.requestHeaders.Size = new System.Drawing.Size(590, 672);
            this.requestHeaders.TabIndex = 2;
            this.requestHeaders.UseCompatibleStateImageBehavior = false;
            this.requestHeaders.View = System.Windows.Forms.View.Details;
            // 
            // responseHeaders
            // 
            this.responseHeaders.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseHeaders.HideSelection = false;
            this.responseHeaders.Location = new System.Drawing.Point(772, 88);
            this.responseHeaders.Name = "responseHeaders";
            this.responseHeaders.Size = new System.Drawing.Size(590, 672);
            this.responseHeaders.TabIndex = 3;
            this.responseHeaders.UseCompatibleStateImageBehavior = false;
            this.responseHeaders.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "HTTP request headers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(766, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "HTTP response headers:";
            // 
            // ShowHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 809);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.responseHeaders);
            this.Controls.Add(this.requestHeaders);
            this.Name = "ShowHeader";
            this.Text = "ShowHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView requestHeaders;
        private System.Windows.Forms.ListView responseHeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}