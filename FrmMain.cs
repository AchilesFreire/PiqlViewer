namespace PiqlViewer
{
    public partial class FrmMain : Form
    {

        private const string UnboxToolPath = @"unbox.exe";

        private List<string> listImageExtensions = new List<string>() { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tif", ".tiff" };

        private List<string> listTextExtensions = new List<string>() { ".txt", ".xml", ".json"};
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Events
        private void BtnSelectSourceDir_Click(object sender, EventArgs e)
        {
            PicSourceContent.Image = null;
            PicSourceContent.Invalidate();
            Application.DoEvents();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtSourceDir.Text = folderBrowserDialog1.SelectedPath;
                ListFilesSourceDir();
            }
        }

        private void BtnRefreshSourceDir_Click(object sender, EventArgs e)
        {
            ListFilesSourceDir();
        }

        private void LstSourceDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstSourceDir.SelectedItems.Count != 0)
            {
                ShowFileContent(LstSourceDir.SelectedItems[0].Tag.ToString(), PicSourceContent);
            }
        }

        private void LstSourceDir_DoubleClick(object sender, EventArgs e)
        {
            ShowSelectedSourceFileContent();

        }
        private void PicSourceContent_DoubleClick(object sender, EventArgs e)
        {
            ShowSelectedSourceFileContent();
        }
        private void BtnSelectDestinationDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtDestinationDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnProcessFolder_Click(object sender, EventArgs e)
        {

            if (ProcessFolder(TxtSourceDir.Text, TxtDestinationDir.Text))
            {
                ListFilesDestinationDir();
            }
        }

        private void LstDestinationFiles_DoubleClick(object sender, EventArgs e)
        {
            ShowSelectedDestinationFileContent();
        }


        private void LstDestinationFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstDestinationFiles.SelectedItems.Count != 0)
            {
                var filePath = LstDestinationFiles.SelectedItems[0].Tag.ToString();
                var ext = Path.GetExtension(filePath).ToLower() ;
                var isImage = listImageExtensions.Contains(ext);
                if(isImage)
                    ShowFileContent(filePath, PicDestinationContent);
                else
                    PicDestinationContent.Image = null;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDirectoryDefaultValues();

        }
        #endregion


        #region Methods

        private void LoadDirectoryDefaultValues()
        {
            var defaultSourceDir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Source");
            var defaultDestinationDir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Destination");
            if (!Directory.Exists(defaultSourceDir))
                Directory.CreateDirectory(defaultSourceDir);
            if (!Directory.Exists(defaultDestinationDir))
                Directory.CreateDirectory(defaultDestinationDir);
            TxtSourceDir.Text = defaultSourceDir;
            TxtDestinationDir.Text = defaultDestinationDir;
            ListFilesSourceDir();
        }
        private void ListFilesSourceDir()
        {
            try
            {
                LstSourceDir.Items.Clear();
                var files = Directory.GetFiles(TxtSourceDir.Text, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    var li = LstSourceDir.Items.Add(Path.GetFileName(file));
                    li.Tag = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void ShowFileContent(string file, PictureBox pic)
        {
            try
            {
                pic.Image = Image.FromFile(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                PicSourceContent.Image = null;
            }
        }

        private void ShowSelectedSourceFileContent()
        {
            try
            {
                if (LstSourceDir.SelectedItems.Count == 0)
                    return;

                ShowImageContent(LstSourceDir.SelectedItems[0].Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ShowImageContent(string imagefilename)
        {
            try
            {
                var viewer = new FrmImageViewer();
                viewer.ImageFilePath = imagefilename;
                viewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private Boolean ProcessFolder(string sourceDir, string destinationDir)
        {
            try
            {
                if (!File.Exists(UnboxToolPath))
                {
                    MessageBox.Show($"Unbox tool not found {UnboxToolPath} \n\nIn current path {Path.GetDirectoryName(Application.ExecutablePath)}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!ValidateFolders(sourceDir, destinationDir))
                    return false;

                this.UseWaitCursor = true;
                LblWaitForFinish.Visible = true;
                Application.DoEvents();

                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = UnboxToolPath,
                    Arguments = $"\"{sourceDir}\" \"{destinationDir}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var proc = System.Diagnostics.Process.Start(startInfo))
                {
                    if (proc == null)
                        return false;

                    // Ler saídas enquanto aguarda encerramento para evitar deadlocks em alguns cenários
                    var outputTask = proc.StandardOutput.ReadToEndAsync();
                    var errorTask = proc.StandardError.ReadToEndAsync();

                    proc.WaitForExit();

                    var stdout = outputTask.Result;
                    var stderr = errorTask.Result;

                    if (!string.IsNullOrEmpty(stdout))
                        System.Diagnostics.Debug.WriteLine(stdout);
                    if (!string.IsNullOrEmpty(stderr))
                        System.Diagnostics.Debug.WriteLine(stderr);

                    return proc.ExitCode == 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            finally
            {
                LblWaitForFinish.Visible = false;
                this.UseWaitCursor = false;
                Application.DoEvents();

            }
        }

        private Boolean ValidateFolders(string sourceDir, string destinationDir)
        {
            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("Source directory does not exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Directory.GetFiles(sourceDir).Length == 0)
            {
                MessageBox.Show("Source directory is empty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Directory.Exists(destinationDir))
            {
                MessageBox.Show("Destination directory does not exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ListFilesDestinationDir()
        {
            LstDestinationFiles.Items.Clear();
            var files = Directory.GetFiles(TxtDestinationDir.Text, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var li = LstDestinationFiles.Items.Add(Path.GetFileName(file));
                li.Tag = file;
            }
        }


        private void ShowSelectedDestinationFileContent()
        {
            try
            {
                if (LstDestinationFiles.SelectedItems.Count == 0)
                    return;

                var fileName = LstDestinationFiles.SelectedItems[0].Tag as string;
                if (string.IsNullOrWhiteSpace(fileName))
                    return;

                var ext = Path.GetExtension(fileName.ToLower()) ?? string.Empty;
                var isImage = listImageExtensions.Contains(ext);

                if (isImage)
                {
                    ShowImageContent(fileName);
                }
                else
                {

                    var isText = listTextExtensions.Contains(ext);
                    if (isText)
                    {
                        var viewer = new FrmTextViewer();
                        viewer.TextFilePath = fileName;
                        viewer.ShowDialog();
                        return;
                    }
                    var startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = fileName,
                        UseShellExecute = true,
                        Verb = "open"
                    };
                    System.Diagnostics.Process.Start(startInfo);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion



    }
}