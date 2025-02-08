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
                encryptButtonsEnabled(true, !String.IsNullOrEmpty(txtEncryptSelectedFile.Text));
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
                saveFileDialog.Filter = "Arquivo criptografado|*.wcry";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    encryptButtonsEnabled(false, false);
                    txtEncryptOutputFile.Text = saveFileDialog.FileName;
                    var progress = new Progress<double>(percent =>
                    {
                        prgsEncryptFile.Value = (int)(percent * 100);
                    });

                    await fileEncryptor.EncryptFileAsync(txtEncryptPassword.Text, txtEncryptSelectedFile.Text, txtEncryptOutputFile.Text, progress);
                    prgsEncryptFile.Value = 0;
                    encryptButtonsEnabled(true, false);
                    MessageBox.Show("Arquivo criptografado com sucesso!");
                }
            }
        }

        private void btnSelectdecryptFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivo criptografado|*.wcry";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDecryptSelectedFile.Text = openFileDialog.FileName;
                }
                else
                {
                    txtDecryptSelectedFile.Clear();
                    txtDecryptOutputFile.Clear();
                }
                decryptButtonsEnabled(true, !String.IsNullOrEmpty(txtDecryptSelectedFile.Text));
            }
        }

        private async void btnDecryptStart_Click(object sender, EventArgs e)
        {
            string tempOutputFilePath = Path.GetTempFileName(); // Nome temporário para o arquivo descriptografado

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    decryptButtonsEnabled(false, false);
                    var progress = new Progress<double>(percent =>
                    {
                        prgsDecryptFile.Value = (int)(percent * 100);
                    });

                    var (success, originalFileName) = await fileEncryptor.DecryptFileAsync(txtDecryptPassword.Text, txtDecryptSelectedFile.Text, tempOutputFilePath, progress);
                    if (success)
                    {
                        // Caminho final para o arquivo descriptografado
                        string outputDirectory = folderDialog.SelectedPath;
                        string finalOutputFilePath = Path.Combine(outputDirectory, "decripted_" + originalFileName);

                        // Verifica se o arquivo já existe
                        if (File.Exists(finalOutputFilePath))
                        {
                            var result = MessageBox.Show($"O arquivo 'decripted_{originalFileName}' já existe. Deseja substituí-lo?", "Arquivo Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                // Remove o arquivo temporário e retorna
                                File.Delete(tempOutputFilePath);
                                return;
                            }
                        }

                        // Renomeia o arquivo descriptografado
                        File.Move(tempOutputFilePath, finalOutputFilePath, true);

                        prgsDecryptFile.Value = 0;
                        decryptButtonsEnabled(true, true);
                        MessageBox.Show($"Arquivo descriptografado com sucesso!");// Nome original: {originalFileName}\nSalvo como: {finalOutputFilePath}");
                    }
                    else
                    {
                        // Remove o arquivo temporário em caso de falha
                        File.Delete(tempOutputFilePath);

                        prgsDecryptFile.Value = 0;
                        decryptButtonsEnabled(true, true);
                        MessageBox.Show("Senha incorreta ou erro ao descriptografar o arquivo.");
                    }
                }
            }
        }

        private void encryptButtonsEnabled(bool enableSelectFile, bool enableStart)
        {
            btnSelectEncryptFile.Enabled = enableSelectFile;
            btnEncryptStart.Enabled = enableStart;
        }

        private void decryptButtonsEnabled(bool enableSelectFile, bool enableStart)
        {
            btnSelectdecryptFile.Enabled = enableSelectFile;
            btnDecryptStart.Enabled = enableStart;
        }
    }
}