namespace WinCRPY
{
    public partial class frmChoiceTool : Form
    {
        public frmChoiceTool()
        {
            InitializeComponent();
        }

        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            frmFileEncrypt frmFileEncrypt = new frmFileEncrypt();
            frmFileEncrypt.ShowDialog(this);
            frmFileEncrypt.Dispose();
        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            frmPlainTextEncrypt frmPlainTextEncrypt = new frmPlainTextEncrypt();
            frmPlainTextEncrypt.ShowDialog(this);
            frmPlainTextEncrypt.Dispose();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog(this);
            frmAbout.Dispose();
        }
    }
}
