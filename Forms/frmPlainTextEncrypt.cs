using System.Security.Cryptography;

namespace WinCRPY
{
    public partial class frmPlainTextEncrypt : Form
    {
        private TextEncryptor textEncryptor;
        public frmPlainTextEncrypt()
        {
            InitializeComponent();
            textEncryptor = new TextEncryptor();
        }

        private void frmPlainTextEncrypt_Resize(object sender, EventArgs e)
        {
            resizeControls();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtResult.Text = textEncryptor.EncryptText(txtPassword.Text, txtText.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = textEncryptor.DecryptText(txtPassword.Text, txtText.Text);
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Senha incorreta ou erro ao descriptografar o texto.");
            }
            catch (Exception)
            {
                MessageBox.Show("Houve uma falha desconhecida, verifique o conteúdo que está tentando descriptografar é valido, ou seja, não é texto plano, etc.");
            }
        }

        private void resizeControls()
        {
            txtText.Size = new Size(this.ClientSize.Width - txtText.Left * 2, (this.ClientSize.Height / 2) - txtPassword.Height - lblResultado.Height);
            lblSenha.Top = txtText.Height + lblResultado.Height + 10;
            txtPassword.Top = lblSenha.Top;
            btnEncrypt.Top = lblSenha.Top;
            btnDecrypt.Top = btnEncrypt.Top;
            lblResultado.Top = txtPassword.Top + lblResultado.Height + 10;
            txtResult.Top = lblResultado.Top + lblResultado.Height + 5;
            txtResult.Size = new Size(this.ClientSize.Width - txtText.Left * 2, (this.ClientSize.Height / 2) - txtPassword.Height - lblResultado.Height);
        }

        private void frmPlainTextEncrypt_Load(object sender, EventArgs e)
        {
            resizeControls();
        }
    }
}
