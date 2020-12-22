//-----------------------------------------------------------------------
// Author  : Armin Ahmadi
// Gmail   : developershub.organization@gmail.com
// Email   : support@developershub.org
// Website : www.developershub.org
// Copyright © 2020, Developers Hub
// All rights reserved
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace DevelopersHub
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttonEncrypt.Text == "Encrypt")
                {
                    if (!string.IsNullOrEmpty(richTextBoxEncryptText.Text.Trim()) && !string.IsNullOrEmpty(textBoxEncryptPassword.Text.Trim()))
                    {
                        buttonEncrypt.Text = "Reset";
                        richTextBoxEncryptText.Text = Encryption.Encrypt(richTextBoxEncryptText.Text.Trim(), textBoxEncryptPassword.Text.Trim());
                        richTextBoxEncryptText.ReadOnly = true;
                        textBoxEncryptPassword.ReadOnly = true;
                    }
                }
                else
                {
                    buttonEncrypt.Text = "Encrypt";
                    richTextBoxEncryptText.Text = "";
                    richTextBoxEncryptText.ReadOnly = false;
                    textBoxEncryptPassword.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to encrypt the data.", "Encrypt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonDecrypt.Text == "Decrypt")
                {
                    if (!string.IsNullOrEmpty(richTextBoxDecryptText.Text.Trim()) && !string.IsNullOrEmpty(textBoxDecryptPassword.Text.Trim()))
                    {
                        buttonDecrypt.Text = "Reset";
                        richTextBoxDecryptText.Text = Encryption.Decrypt(richTextBoxDecryptText.Text.Trim(), textBoxDecryptPassword.Text.Trim());
                        richTextBoxDecryptText.ReadOnly = true;
                        textBoxDecryptPassword.ReadOnly = true;
                    }
                }
                else
                {
                    buttonDecrypt.Text = "Decrypt";
                    richTextBoxDecryptText.Text = "";
                    richTextBoxDecryptText.ReadOnly = false;
                    textBoxDecryptPassword.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to dencrypt the data.", "Decrypt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}