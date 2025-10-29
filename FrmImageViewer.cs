using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiqlViewer
{
    public partial class FrmImageViewer : Form
    {
        public FrmImageViewer()
        {
            InitializeComponent();
        }
        public string ImageFilePath { get; set; }

        private void FrmImageViewer_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(ImageFilePath);
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Invalidate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Invalidate();
        }

    }
}
