namespace DevelopersHub
{
    partial class Form1_Main
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
            this.richTextBoxEncryptText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxEncryptPassword = new System.Windows.Forms.TextBox();
            this.textBoxDecryptPassword = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDecryptText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxEncryptText
            // 
            this.richTextBoxEncryptText.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxEncryptText.MaxLength = 10000;
            this.richTextBoxEncryptText.Name = "richTextBoxEncryptText";
            this.richTextBoxEncryptText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxEncryptText.Size = new System.Drawing.Size(460, 96);
            this.richTextBoxEncryptText.TabIndex = 0;
            this.richTextBoxEncryptText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to be encrypted:";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(357, 126);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(115, 24);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // textBoxEncryptPassword
            // 
            this.textBoxEncryptPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEncryptPassword.Location = new System.Drawing.Point(12, 127);
            this.textBoxEncryptPassword.MaxLength = 32;
            this.textBoxEncryptPassword.Name = "textBoxEncryptPassword";
            this.textBoxEncryptPassword.Size = new System.Drawing.Size(339, 22);
            this.textBoxEncryptPassword.TabIndex = 3;
            this.textBoxEncryptPassword.Text = "Password";
            // 
            // textBoxDecryptPassword
            // 
            this.textBoxDecryptPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecryptPassword.Location = new System.Drawing.Point(12, 345);
            this.textBoxDecryptPassword.MaxLength = 32;
            this.textBoxDecryptPassword.Name = "textBoxDecryptPassword";
            this.textBoxDecryptPassword.Size = new System.Drawing.Size(339, 22);
            this.textBoxDecryptPassword.TabIndex = 7;
            this.textBoxDecryptPassword.Text = "Password";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(357, 344);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(115, 24);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text to be decrypted:";
            // 
            // richTextBoxDecryptText
            // 
            this.richTextBoxDecryptText.Location = new System.Drawing.Point(12, 243);
            this.richTextBoxDecryptText.MaxLength = 10000;
            this.richTextBoxDecryptText.Name = "richTextBoxDecryptText";
            this.richTextBoxDecryptText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDecryptText.Size = new System.Drawing.Size(460, 96);
            this.richTextBoxDecryptText.TabIndex = 4;
            this.richTextBoxDecryptText.Text = "";
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 379);
            this.Controls.Add(this.textBoxDecryptPassword);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxDecryptText);
            this.Controls.Add(this.textBoxEncryptPassword);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxEncryptText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1_Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEncryptText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxEncryptPassword;
        private System.Windows.Forms.TextBox textBoxDecryptPassword;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDecryptText;
    }
}

