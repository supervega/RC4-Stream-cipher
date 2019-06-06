using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mhd_ISS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TXTEncrypt.Text = OFD.FileName;
            }
        }

        private void BtnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TXTDecrypt.Text = OFD.FileName;
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dir = TXTEncrypt.Text.Split('\\');
                byte[] directory = UnicodeEncoding.Unicode.GetBytes(dir[dir.Length - 1]);
                FileStream stream = new FileStream(TXTEncrypt.Text, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                stream.Close();
                byte[] newdata = new byte[4 + directory.Length + data.Length];
                BitConverter.GetBytes(directory.Length).CopyTo(newdata, 0);
                directory.CopyTo(newdata, 4);
                data.CopyTo(newdata, 4 + directory.Length);
                RC4 rc = new RC4(TXT_EncryptPassword.Text, UnicodeEncoding.Unicode.GetString(newdata));
                string str = rc.EnDeCrypt();
                File.WriteAllText("Enc_" + (new Random()).Next(1, 53456345), str);
                LblEncResult.Text = "File Encrypted.";
            }
            catch (Exception ex)
            {
                LblEncResult.Text = "Failed.";
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {                
                string Enstrdata=File.ReadAllText(TXTDecrypt.Text);
                RC4 rc=new RC4(TXT_DecryptPassword.Text,Enstrdata);
                string newstr= rc.EnDeCrypt();
                byte[] data = UnicodeEncoding.Unicode.GetBytes(newstr);
                int len = BitConverter.ToInt32(data, 0);
                string FileName = UnicodeEncoding.Unicode.GetString(data, 4, len);
                byte[] filebytes=new byte[data.Length-4-len];
                Array.Copy(data, 4 + len, filebytes, 0, filebytes.Length);
                FileStream strem=new FileStream(FileName, FileMode.Create,FileAccess.Write);
                strem.Write(filebytes, 0, filebytes.Length);
                strem.Close();
                LblDecResult.Text = "File Decrypted.";
            }
            catch (Exception ex)
            {
                LblDecResult.Text = "Failed.";
            }
        }
    }
}
