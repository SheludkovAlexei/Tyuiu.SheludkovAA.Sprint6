using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }
        string path;
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDone_SAA.Enabled = false;
        }

        private void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxText_SAA.Text = File.ReadAllText(path);
            groupBoxText_SAA.Text = groupBoxText_SAA.Text + " " + path;
            buttonDone_SAA.Enabled = true;
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            textBoxResult_SAA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}
