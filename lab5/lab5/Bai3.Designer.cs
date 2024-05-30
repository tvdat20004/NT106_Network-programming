namespace lab5
{
    partial class Bai3
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
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtcontent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.btnattachment = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Location = new System.Drawing.Point(120, 11);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(353, 30);
            this.txtfrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // txtto
            // 
            this.txtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.Location = new System.Drawing.Point(120, 63);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(353, 30);
            this.txtto.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(600, 13);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 29);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(747, 11);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(320, 30);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(120, 206);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(581, 385);
            this.txtcontent.TabIndex = 6;
            this.txtcontent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Content";
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(521, 606);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(180, 90);
            this.btnsend.TabIndex = 8;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject";
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.Location = new System.Drawing.Point(120, 132);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(581, 30);
            this.txtsubject.TabIndex = 9;
            this.txtsubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnattachment
            // 
            this.btnattachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattachment.Location = new System.Drawing.Point(120, 606);
            this.btnattachment.Name = "btnattachment";
            this.btnattachment.Size = new System.Drawing.Size(180, 90);
            this.btnattachment.TabIndex = 11;
            this.btnattachment.Text = "Attachment";
            this.btnattachment.UseVisualStyleBackColor = true;
            this.btnattachment.Click += new System.EventHandler(this.btnattachment_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(844, 206);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(291, 385);
            this.txtpath.TabIndex = 12;
            this.txtpath.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(762, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Path";
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(844, 606);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(291, 90);
            this.btnremove.TabIndex = 14;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 708);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnattachment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfrom);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.RichTextBox txtcontent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Button btnattachment;
        private System.Windows.Forms.RichTextBox txtpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnremove;
    }
}