namespace PiqlViewer
{
    partial class FrmMain
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
            panel1 = new Panel();
            label5 = new Label();
            PicSourceContent = new PictureBox();
            LstSourceDir = new ListView();
            ColFile = new ColumnHeader();
            BtnRefreshSourceDir = new Button();
            BtnSelectSourceDir = new Button();
            label2 = new Label();
            label1 = new Label();
            TxtSourceDir = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            label6 = new Label();
            PicDestinationContent = new PictureBox();
            LblWaitForFinish = new Label();
            LstDestinationFiles = new ListView();
            columnHeader1 = new ColumnHeader();
            label4 = new Label();
            BtnProcessFolder = new Button();
            BtnSelectDestinationDir = new Button();
            label3 = new Label();
            TxtDestinationDir = new TextBox();
            splitContainer1 = new SplitContainer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicSourceContent).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicDestinationContent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PicSourceContent);
            panel1.Controls.Add(LstSourceDir);
            panel1.Controls.Add(BtnRefreshSourceDir);
            panel1.Controls.Add(BtnSelectSourceDir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtSourceDir);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 695);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(146, 56);
            label5.Name = "label5";
            label5.Size = new Size(211, 15);
            label5.TabIndex = 5;
            label5.Text = "(doubleclick to open in new window)";
            // 
            // PicSourceContent
            // 
            PicSourceContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PicSourceContent.BackColor = Color.Gray;
            PicSourceContent.Location = new Point(8, 340);
            PicSourceContent.Name = "PicSourceContent";
            PicSourceContent.Size = new Size(545, 345);
            PicSourceContent.SizeMode = PictureBoxSizeMode.StretchImage;
            PicSourceContent.TabIndex = 4;
            PicSourceContent.TabStop = false;
            PicSourceContent.DoubleClick += PicSourceContent_DoubleClick;
            // 
            // LstSourceDir
            // 
            LstSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LstSourceDir.Columns.AddRange(new ColumnHeader[] { ColFile });
            LstSourceDir.Location = new Point(8, 74);
            LstSourceDir.MultiSelect = false;
            LstSourceDir.Name = "LstSourceDir";
            LstSourceDir.Size = new Size(545, 253);
            LstSourceDir.TabIndex = 2;
            LstSourceDir.UseCompatibleStateImageBehavior = false;
            LstSourceDir.View = View.Details;
            LstSourceDir.SelectedIndexChanged += LstSourceDir_SelectedIndexChanged;
            LstSourceDir.DoubleClick += LstSourceDir_DoubleClick;
            // 
            // ColFile
            // 
            ColFile.Text = "Files";
            ColFile.Width = 555;
            // 
            // BtnRefreshSourceDir
            // 
            BtnRefreshSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRefreshSourceDir.Location = new Point(491, 25);
            BtnRefreshSourceDir.Name = "BtnRefreshSourceDir";
            BtnRefreshSourceDir.Size = new Size(62, 23);
            BtnRefreshSourceDir.TabIndex = 1;
            BtnRefreshSourceDir.Text = "Refresh";
            BtnRefreshSourceDir.UseVisualStyleBackColor = true;
            BtnRefreshSourceDir.Click += BtnRefreshSourceDir_Click;
            // 
            // BtnSelectSourceDir
            // 
            BtnSelectSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSelectSourceDir.Location = new Point(453, 23);
            BtnSelectSourceDir.Name = "BtnSelectSourceDir";
            BtnSelectSourceDir.Size = new Size(32, 23);
            BtnSelectSourceDir.TabIndex = 0;
            BtnSelectSourceDir.Text = "...";
            BtnSelectSourceDir.UseVisualStyleBackColor = true;
            BtnSelectSourceDir.Click += BtnSelectSourceDir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "(click to see the content)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Source Directory:";
            // 
            // TxtSourceDir
            // 
            TxtSourceDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSourceDir.Location = new Point(8, 24);
            TxtSourceDir.Name = "TxtSourceDir";
            TxtSourceDir.ReadOnly = true;
            TxtSourceDir.Size = new Size(439, 23);
            TxtSourceDir.TabIndex = 0;
            TxtSourceDir.Text = "D:\\TRABALHO\\Piql\\PiqlViewer\\PiqlViewer\\bin\\Debug\\net8.0-windows\\Achiles";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(PicDestinationContent);
            panel2.Controls.Add(LblWaitForFinish);
            panel2.Controls.Add(LstDestinationFiles);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnProcessFolder);
            panel2.Controls.Add(BtnSelectDestinationDir);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TxtDestinationDir);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 695);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(67, 97);
            label6.Name = "label6";
            label6.Size = new Size(211, 15);
            label6.TabIndex = 11;
            label6.Text = "(doubleclick to open in new window)";
            // 
            // PicDestinationContent
            // 
            PicDestinationContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PicDestinationContent.BackColor = Color.Gray;
            PicDestinationContent.Location = new Point(14, 340);
            PicDestinationContent.Name = "PicDestinationContent";
            PicDestinationContent.Size = new Size(508, 345);
            PicDestinationContent.SizeMode = PictureBoxSizeMode.StretchImage;
            PicDestinationContent.TabIndex = 10;
            PicDestinationContent.TabStop = false;
            // 
            // LblWaitForFinish
            // 
            LblWaitForFinish.AutoSize = true;
            LblWaitForFinish.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblWaitForFinish.ForeColor = Color.Red;
            LblWaitForFinish.Location = new Point(173, 67);
            LblWaitForFinish.Name = "LblWaitForFinish";
            LblWaitForFinish.Size = new Size(118, 21);
            LblWaitForFinish.TabIndex = 9;
            LblWaitForFinish.Text = "Wait for finish";
            LblWaitForFinish.Visible = false;
            // 
            // LstDestinationFiles
            // 
            LstDestinationFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LstDestinationFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            LstDestinationFiles.Location = new Point(14, 115);
            LstDestinationFiles.MultiSelect = false;
            LstDestinationFiles.Name = "LstDestinationFiles";
            LstDestinationFiles.Size = new Size(508, 212);
            LstDestinationFiles.TabIndex = 5;
            LstDestinationFiles.UseCompatibleStateImageBehavior = false;
            LstDestinationFiles.View = View.Details;
            LstDestinationFiles.SelectedIndexChanged += LstDestinationFiles_SelectedIndexChanged;
            LstDestinationFiles.DoubleClick += LstDestinationFiles_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Files";
            columnHeader1.Width = 555;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 97);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Results:";
            // 
            // BtnProcessFolder
            // 
            BtnProcessFolder.Location = new Point(14, 65);
            BtnProcessFolder.Name = "BtnProcessFolder";
            BtnProcessFolder.Size = new Size(153, 23);
            BtnProcessFolder.TabIndex = 4;
            BtnProcessFolder.Text = "Process Folder";
            BtnProcessFolder.UseVisualStyleBackColor = true;
            BtnProcessFolder.Click += BtnProcessFolder_Click;
            // 
            // BtnSelectDestinationDir
            // 
            BtnSelectDestinationDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSelectDestinationDir.Location = new Point(490, 25);
            BtnSelectDestinationDir.Name = "BtnSelectDestinationDir";
            BtnSelectDestinationDir.Size = new Size(32, 23);
            BtnSelectDestinationDir.TabIndex = 3;
            BtnSelectDestinationDir.Text = "...";
            BtnSelectDestinationDir.UseVisualStyleBackColor = true;
            BtnSelectDestinationDir.Click += BtnSelectDestinationDir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(14, 7);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 4;
            label3.Text = "Destination Directory:";
            // 
            // TxtDestinationDir
            // 
            TxtDestinationDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDestinationDir.Location = new Point(14, 25);
            TxtDestinationDir.Name = "TxtDestinationDir";
            TxtDestinationDir.ReadOnly = true;
            TxtDestinationDir.Size = new Size(470, 23);
            TxtDestinationDir.TabIndex = 3;
            TxtDestinationDir.Text = "D:\\TRABALHO\\Piql\\PiqlViewer\\PiqlViewer\\bin\\Debug\\net8.0-windows\\Destination";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1112, 695);
            splitContainer1.SplitterDistance = 571;
            splitContainer1.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 695);
            Controls.Add(splitContainer1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Piql viewer";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicSourceContent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicDestinationContent).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox PicSourceContent;
        private ListView LstSourceDir;
        private Button BtnSelectSourceDir;
        private Label label2;
        private Label label1;
        private TextBox TxtSourceDir;
        private FolderBrowserDialog folderBrowserDialog1;
        private ColumnHeader ColFile;
        private Panel panel2;
        private Button BtnSelectDestinationDir;
        private Label label3;
        private TextBox TxtDestinationDir;
        private SplitContainer splitContainer1;
        private ListView LstDestinationFiles;
        private ColumnHeader columnHeader1;
        private Label label4;
        private Button BtnProcessFolder;
        private Button BtnRefreshSourceDir;
        private Label LblWaitForFinish;
        private PictureBox PicDestinationContent;
        private Label label5;
        private Label label6;
    }
}
