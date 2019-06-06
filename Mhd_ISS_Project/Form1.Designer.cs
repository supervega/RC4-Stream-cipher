namespace Mhd_ISS_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_EncryptPassword = new System.Windows.Forms.TextBox();
            this.BtnBrowseEncrypt = new System.Windows.Forms.Button();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.TXTEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_DecryptPassword = new System.Windows.Forms.TextBox();
            this.BtnBrowseDecrypt = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.TXTDecrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblEncResult = new System.Windows.Forms.Label();
            this.LblDecResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LblEncResult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXT_EncryptPassword);
            this.panel1.Controls.Add(this.BtnBrowseEncrypt);
            this.panel1.Controls.Add(this.BtnEncrypt);
            this.panel1.Controls.Add(this.TXTEncrypt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 152);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // TXT_EncryptPassword
            // 
            this.TXT_EncryptPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_EncryptPassword.Location = new System.Drawing.Point(136, 65);
            this.TXT_EncryptPassword.Name = "TXT_EncryptPassword";
            this.TXT_EncryptPassword.Size = new System.Drawing.Size(311, 27);
            this.TXT_EncryptPassword.TabIndex = 5;
            // 
            // BtnBrowseEncrypt
            // 
            this.BtnBrowseEncrypt.Font = new System.Drawing.Font("Motorwerk", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBrowseEncrypt.Location = new System.Drawing.Point(446, 25);
            this.BtnBrowseEncrypt.Name = "BtnBrowseEncrypt";
            this.BtnBrowseEncrypt.Size = new System.Drawing.Size(47, 30);
            this.BtnBrowseEncrypt.TabIndex = 4;
            this.BtnBrowseEncrypt.Text = "...";
            this.BtnBrowseEncrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBrowseEncrypt.UseVisualStyleBackColor = true;
            this.BtnBrowseEncrypt.Click += new System.EventHandler(this.BtnBrowseEncrypt_Click);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEncrypt.Location = new System.Drawing.Point(136, 98);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(124, 40);
            this.BtnEncrypt.TabIndex = 3;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // TXTEncrypt
            // 
            this.TXTEncrypt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTEncrypt.Location = new System.Drawing.Point(136, 27);
            this.TXTEncrypt.Name = "TXTEncrypt";
            this.TXTEncrypt.Size = new System.Drawing.Size(311, 27);
            this.TXTEncrypt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.LblDecResult);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TXT_DecryptPassword);
            this.panel2.Controls.Add(this.BtnBrowseDecrypt);
            this.panel2.Controls.Add(this.BtnDecrypt);
            this.panel2.Controls.Add(this.TXTDecrypt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 152);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password :";
            // 
            // TXT_DecryptPassword
            // 
            this.TXT_DecryptPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DecryptPassword.Location = new System.Drawing.Point(136, 66);
            this.TXT_DecryptPassword.Name = "TXT_DecryptPassword";
            this.TXT_DecryptPassword.Size = new System.Drawing.Size(311, 27);
            this.TXT_DecryptPassword.TabIndex = 7;
            // 
            // BtnBrowseDecrypt
            // 
            this.BtnBrowseDecrypt.Font = new System.Drawing.Font("Motorwerk", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseDecrypt.ForeColor = System.Drawing.Color.Green;
            this.BtnBrowseDecrypt.Location = new System.Drawing.Point(446, 27);
            this.BtnBrowseDecrypt.Name = "BtnBrowseDecrypt";
            this.BtnBrowseDecrypt.Size = new System.Drawing.Size(47, 30);
            this.BtnBrowseDecrypt.TabIndex = 5;
            this.BtnBrowseDecrypt.Text = "...";
            this.BtnBrowseDecrypt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBrowseDecrypt.UseVisualStyleBackColor = true;
            this.BtnBrowseDecrypt.Click += new System.EventHandler(this.BtnBrowseDecrypt_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecrypt.ForeColor = System.Drawing.Color.Green;
            this.BtnDecrypt.Location = new System.Drawing.Point(136, 99);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(124, 40);
            this.BtnDecrypt.TabIndex = 4;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // TXTDecrypt
            // 
            this.TXTDecrypt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDecrypt.Location = new System.Drawing.Point(136, 28);
            this.TXTDecrypt.Name = "TXTDecrypt";
            this.TXTDecrypt.Size = new System.Drawing.Size(311, 27);
            this.TXTDecrypt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name : ";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Blue;
            this.BtnClose.Location = new System.Drawing.Point(211, 339);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(105, 40);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblEncResult
            // 
            this.LblEncResult.AutoSize = true;
            this.LblEncResult.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncResult.ForeColor = System.Drawing.Color.White;
            this.LblEncResult.Location = new System.Drawing.Point(266, 113);
            this.LblEncResult.Name = "LblEncResult";
            this.LblEncResult.Size = new System.Drawing.Size(0, 25);
            this.LblEncResult.TabIndex = 7;
            // 
            // LblDecResult
            // 
            this.LblDecResult.AutoSize = true;
            this.LblDecResult.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDecResult.ForeColor = System.Drawing.Color.White;
            this.LblDecResult.Location = new System.Drawing.Point(266, 114);
            this.LblDecResult.Name = "LblDecResult";
            this.LblDecResult.Size = new System.Drawing.Size(0, 25);
            this.LblDecResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.TextBox TXTEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDecrypt;
        private System.Windows.Forms.TextBox TXTDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBrowseEncrypt;
        private System.Windows.Forms.Button BtnBrowseDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_EncryptPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_DecryptPassword;
        private System.Windows.Forms.Label LblEncResult;
        private System.Windows.Forms.Label LblDecResult;

    }
}

