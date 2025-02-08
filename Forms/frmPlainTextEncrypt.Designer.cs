namespace WinCRPY
{
    partial class frmPlainTextEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlainTextEncrypt));
            label1 = new Label();
            txtText = new TextBox();
            txtPassword = new TextBox();
            lblSenha = new Label();
            lblResultado = new Label();
            txtResult = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 1);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtText
            // 
            txtText.AcceptsReturn = true;
            txtText.AcceptsTab = true;
            txtText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtText.Location = new Point(6, 18);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.ScrollBars = ScrollBars.Both;
            txtText.Size = new Size(1315, 176);
            txtText.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(51, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(1078, 23);
            txtPassword.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(6, 203);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(6, 233);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // txtResult
            // 
            txtResult.AcceptsReturn = true;
            txtResult.AcceptsTab = true;
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Location = new Point(6, 253);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(1315, 398);
            txtResult.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEncrypt.Location = new Point(1135, 200);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(80, 23);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Criptografar";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDecrypt.Location = new Point(1221, 200);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(100, 23);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Descriptografar";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // frmPlainTextEncrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 663);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtResult);
            Controls.Add(lblResultado);
            Controls.Add(lblSenha);
            Controls.Add(txtPassword);
            Controls.Add(txtText);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmPlainTextEncrypt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlainText Encrypt Tool";
            Load += frmPlainTextEncrypt_Load;
            Resize += frmPlainTextEncrypt_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtText;
        private TextBox txtPassword;
        private Label lblSenha;
        private Label lblResultado;
        private TextBox txtResult;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}