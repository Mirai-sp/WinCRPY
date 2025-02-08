namespace WinCRPY
{
    partial class frmChoiceTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoiceTool));
            btnFileEncrypt = new Button();
            btnEncryptText = new Button();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // btnFileEncrypt
            // 
            btnFileEncrypt.Location = new Point(12, 12);
            btnFileEncrypt.Name = "btnFileEncrypt";
            btnFileEncrypt.Size = new Size(98, 50);
            btnFileEncrypt.TabIndex = 0;
            btnFileEncrypt.Text = "Criptografar Arquivo";
            btnFileEncrypt.UseVisualStyleBackColor = true;
            btnFileEncrypt.Click += btnFileEncrypt_Click;
            // 
            // btnEncryptText
            // 
            btnEncryptText.Location = new Point(116, 12);
            btnEncryptText.Name = "btnEncryptText";
            btnEncryptText.Size = new Size(98, 50);
            btnEncryptText.TabIndex = 1;
            btnEncryptText.Text = "Criptografar Texto";
            btnEncryptText.UseVisualStyleBackColor = true;
            btnEncryptText.Click += btnEncryptText_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(220, 12);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(98, 50);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "Sobre";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // frmChoiceTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 72);
            Controls.Add(btnAbout);
            Controls.Add(btnEncryptText);
            Controls.Add(btnFileEncrypt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmChoiceTool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinCRPY - Encryption Tool";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFileEncrypt;
        private Button btnEncryptText;
        private Button btnAbout;
    }
}