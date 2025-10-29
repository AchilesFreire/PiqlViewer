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
    public partial class FrmTextViewer : Form
    {
        public string TextFilePath { get; set; }
        public FrmTextViewer()
        {
            InitializeComponent();
        }

        private void FrmTextViewer_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.File.ReadAllText(TextFilePath).Replace(">",">\r\n");
        }
    }
}
