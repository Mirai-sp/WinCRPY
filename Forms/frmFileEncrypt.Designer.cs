namespace WinCRPY
{
    partial class frmFileEncrypt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileEncrypt));
            grpEncript = new GroupBox();
            prgsEncryptFile = new ProgressBar();
            txtEncryptOutputFile = new TextBox();
            label5 = new Label();
            txtEncryptPassword = new TextBox();
            label2 = new Label();
            txtEncryptSelectedFile = new TextBox();
            label1 = new Label();
            btnEncryptStart = new Button();
            btnSelectEncryptFile = new Button();
            grpDecrypt = new GroupBox();
            prgsDecryptFile = new ProgressBar();
            txtDecryptOutputFile = new TextBox();
            label6 = new Label();
            txtDecryptPassword = new TextBox();
            label4 = new Label();
            btnDecryptStart = new Button();
            btnSelectdecryptFile = new Button();
            txtDecryptSelectedFile = new TextBox();
            label3 = new Label();
            grpEncript.SuspendLayout();
            grpDecrypt.SuspendLayout();
            SuspendLayout();
            // 
            // grpEncript
            // 
            grpEncript.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpEncript.BackgroundImageLayout = ImageLayout.Stretch;
            grpEncript.Controls.Add(prgsEncryptFile);
            grpEncript.Controls.Add(txtEncryptOutputFile);
            grpEncript.Controls.Add(label5);
            grpEncript.Controls.Add(txtEncryptPassword);
            grpEncript.Controls.Add(label2);
            grpEncript.Controls.Add(txtEncryptSelectedFile);
            grpEncript.Controls.Add(label1);
            grpEncript.Controls.Add(btnEncryptStart);
            grpEncript.Controls.Add(btnSelectEncryptFile);
            grpEncript.Location = new Point(12, 12);
            grpEncript.Name = "grpEncript";
            grpEncript.Size = new Size(551, 254);
            grpEncript.TabIndex = 2;
            grpEncript.TabStop = false;
            grpEncript.Text = "Encrypt";
            // 
            // prgsEncryptFile
            // 
            prgsEncryptFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgsEncryptFile.Location = new Point(6, 170);
            prgsEncryptFile.Name = "prgsEncryptFile";
            prgsEncryptFile.Size = new Size(539, 23);
            prgsEncryptFile.TabIndex = 9;
            // 
            // txtEncryptOutputFile
            // 
            txtEncryptOutputFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptOutputFile.Location = new Point(6, 87);
            txtEncryptOutputFile.Name = "txtEncryptOutputFile";
            txtEncryptOutputFile.ReadOnly = true;
            txtEncryptOutputFile.Size = new Size(539, 23);
            txtEncryptOutputFile.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 7;
            label5.Text = "Arquivo de saída";
            // 
            // txtEncryptPassword
            // 
            txtEncryptPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptPassword.Location = new Point(6, 137);
            txtEncryptPassword.Name = "txtEncryptPassword";
            txtEncryptPassword.PasswordChar = '*';
            txtEncryptPassword.Size = new Size(539, 23);
            txtEncryptPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 120);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // txtEncryptSelectedFile
            // 
            txtEncryptSelectedFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptSelectedFile.Location = new Point(6, 40);
            txtEncryptSelectedFile.Name = "txtEncryptSelectedFile";
            txtEncryptSelectedFile.ReadOnly = true;
            txtEncryptSelectedFile.Size = new Size(539, 23);
            txtEncryptSelectedFile.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Arquivo Selecionado";
            // 
            // btnEncryptStart
            // 
            btnEncryptStart.Anchor = AnchorStyles.Bottom;
            btnEncryptStart.Enabled = false;
            btnEncryptStart.Location = new Point(452, 199);
            btnEncryptStart.Name = "btnEncryptStart";
            btnEncryptStart.Size = new Size(93, 46);
            btnEncryptStart.TabIndex = 2;
            btnEncryptStart.Text = "Iniciar";
            btnEncryptStart.UseVisualStyleBackColor = true;
            btnEncryptStart.Click += btnEncryptStart_Click;
            // 
            // btnSelectEncryptFile
            // 
            btnSelectEncryptFile.Anchor = AnchorStyles.Bottom;
            btnSelectEncryptFile.Location = new Point(6, 199);
            btnSelectEncryptFile.Name = "btnSelectEncryptFile";
            btnSelectEncryptFile.Size = new Size(128, 46);
            btnSelectEncryptFile.TabIndex = 1;
            btnSelectEncryptFile.Text = "Selecionar Arquivo";
            btnSelectEncryptFile.UseVisualStyleBackColor = true;
            btnSelectEncryptFile.Click += btnSelectEncryptFile_Click;
            // 
            // grpDecrypt
            // 
            grpDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDecrypt.BackgroundImageLayout = ImageLayout.Stretch;
            grpDecrypt.Controls.Add(prgsDecryptFile);
            grpDecrypt.Controls.Add(txtDecryptOutputFile);
            grpDecrypt.Controls.Add(label6);
            grpDecrypt.Controls.Add(txtDecryptPassword);
            grpDecrypt.Controls.Add(label4);
            grpDecrypt.Controls.Add(btnDecryptStart);
            grpDecrypt.Controls.Add(btnSelectdecryptFile);
            grpDecrypt.Controls.Add(txtDecryptSelectedFile);
            grpDecrypt.Controls.Add(label3);
            grpDecrypt.Location = new Point(12, 272);
            grpDecrypt.Name = "grpDecrypt";
            grpDecrypt.Size = new Size(551, 254);
            grpDecrypt.TabIndex = 3;
            grpDecrypt.TabStop = false;
            grpDecrypt.Text = "Decrypt";
            // 
            // prgsDecryptFile
            // 
            prgsDecryptFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prgsDecryptFile.Location = new Point(6, 166);
            prgsDecryptFile.Name = "prgsDecryptFile";
            prgsDecryptFile.Size = new Size(539, 23);
            prgsDecryptFile.TabIndex = 12;
            // 
            // txtDecryptOutputFile
            // 
            txtDecryptOutputFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecryptOutputFile.Location = new Point(6, 87);
            txtDecryptOutputFile.Name = "txtDecryptOutputFile";
            txtDecryptOutputFile.ReadOnly = true;
            txtDecryptOutputFile.Size = new Size(539, 23);
            txtDecryptOutputFile.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 10;
            label6.Text = "Arquivo de saída";
            // 
            // txtDecryptPassword
            // 
            txtDecryptPassword.Anchor = AnchorStyles.Bottom;
            txtDecryptPassword.Location = new Point(6, 133);
            txtDecryptPassword.Name = "txtDecryptPassword";
            txtDecryptPassword.PasswordChar = '*';
            txtDecryptPassword.Size = new Size(539, 23);
            txtDecryptPassword.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(6, 116);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // btnDecryptStart
            // 
            btnDecryptStart.Anchor = AnchorStyles.Bottom;
            btnDecryptStart.Enabled = false;
            btnDecryptStart.Location = new Point(452, 197);
            btnDecryptStart.Name = "btnDecryptStart";
            btnDecryptStart.Size = new Size(93, 46);
            btnDecryptStart.TabIndex = 7;
            btnDecryptStart.Text = "Iniciar";
            btnDecryptStart.UseVisualStyleBackColor = true;
            btnDecryptStart.Click += btnDecryptStart_Click;
            // 
            // btnSelectdecryptFile
            // 
            btnSelectdecryptFile.Anchor = AnchorStyles.Bottom;
            btnSelectdecryptFile.Location = new Point(6, 197);
            btnSelectdecryptFile.Name = "btnSelectdecryptFile";
            btnSelectdecryptFile.Size = new Size(128, 46);
            btnSelectdecryptFile.TabIndex = 6;
            btnSelectdecryptFile.Text = "Selecionar Arquivo";
            btnSelectdecryptFile.UseVisualStyleBackColor = true;
            btnSelectdecryptFile.Click += btnSelectdecryptFile_Click;
            // 
            // txtDecryptSelectedFile
            // 
            txtDecryptSelectedFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecryptSelectedFile.Location = new Point(6, 37);
            txtDecryptSelectedFile.Name = "txtDecryptSelectedFile";
            txtDecryptSelectedFile.ReadOnly = true;
            txtDecryptSelectedFile.Size = new Size(539, 23);
            txtDecryptSelectedFile.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 4;
            label3.Text = "Arquivo Selecionado";
            // 
            // frmFileEncrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 538);
            Controls.Add(grpDecrypt);
            Controls.Add(grpEncript);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFileEncrypt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Encrypt";
            grpEncript.ResumeLayout(false);
            grpEncript.PerformLayout();
            grpDecrypt.ResumeLayout(false);
            grpDecrypt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpEncript;
        private Button btnEncryptStart;
        private Button btnSelectEncryptFile;
        private GroupBox grpDecrypt;
        private TextBox txtEncryptPassword;
        private Label label2;
        private TextBox txtEncryptSelectedFile;
        private Label label1;
        private Button btnDecryptStart;
        private Button btnSelectdecryptFile;
        private TextBox txtDecryptSelectedFile;
        private Label label3;
        private TextBox txtDecryptPassword;
        private Label label4;
        private TextBox txtEncryptOutputFile;
        private Label label5;
        private ProgressBar prgsEncryptFile;
        private TextBox txtDecryptOutputFile;
        private Label label6;
        private ProgressBar prgsDecryptFile;
    }
}
