namespace WinCRPY
{
    public partial class frmMain : Form
    {
        private FileEncryptor fileEncryptor;
        public frmMain()
        {
            InitializeComponent();
            fileEncryptor = new FileEncryptor();
        }

        private void grpEncript_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectEncryptFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Todos os tipos de arquivo|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtEncryptSelectedFile.Text = openFileDialog.FileName;
                }
                else
                {
                    txtEncryptSelectedFile.Clear();
                    txtEncryptOutputFile.Clear();
                }
                btnEncryptStart.Enabled = !String.IsNullOrEmpty(txtEncryptSelectedFile.Text);
            }
        }

        private async void btnEncryptStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncryptSelectedFile.Text) || string.IsNullOrEmpty(txtEncryptPassword.Text))
            {
                MessageBox.Show("Por favor, selecione um arquivo e insira uma senha.");
                return;
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Todos os tipos de arquivo|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnSelectdecryptFile.Enabled = false;
                    txtEncryptOutputFile.Text = saveFileDialog.FileName;
                    var progress = new Progress<double>(percent =>
                    {
                        prgsEncryptFile.Value = (int)(percent * 100);
                    });

                    await fileEncryptor.EncryptFileAsync(txtEncryptPassword.Text, txtEncryptSelectedFile.Text, txtEncryptOutputFile.Text, progress);
                    prgsEncryptFile.Value = 0;
                    btnSelectEncryptFile.Enabled = true;
                    btnEncryptStart.Enabled = !btnSelectEncryptFile.Enabled;
                    MessageBox.Show("Arquivo criptografado com sucesso!");
                }
            }
        }

        private void btnSelectdecryptFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDecryptSelectedFile.Text = openFileDialog.FileName;
                }
                else
                {
                    txtDecryptSelectedFile.Clear();
                    txtDecryptOutputFile.Clear();
                }
                btnDecryptStart.Enabled = !String.IsNullOrEmpty(txtDecryptSelectedFile.Text);
            }
        }

        private async void btnDecryptStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptSelectedFile.Text) || string.IsNullOrEmpty(txtDecryptPassword.Text))
            {
                MessageBox.Show("Por favor, selecione um arquivo e insira uma senha.");
                return;
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnSelectdecryptFile.Enabled = false;
                    txtDecryptOutputFile.Text = saveFileDialog.FileName;
                    var progress = new Progress<double>(percent =>
                    {
                        prgsDecryptFile.Value = (int)(percent * 100);
                    });

                    await fileEncryptor.DecryptFileAsync(txtDecryptPassword.Text, txtDecryptSelectedFile.Text, txtDecryptOutputFile.Text, progress);
                    prgsDecryptFile.Value = 0;
                    btnSelectdecryptFile.Enabled = true;
                    btnDecryptStart.Enabled = !btnSelectdecryptFile.Enabled;
                    MessageBox.Show("Arquivo descriptografado com sucesso!");

                }
            }
        }
    }
}