using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task1.V2.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int st = Convert.ToInt32(textBoxStart_SAA.Text);
                int end = Convert.ToInt32(textBoxEnd_SAA.Text);
                string str;
                int len = end - st + 1;
                double[] arr = new double[len];
                arr = ds.GetMassFunction(st, end);
                textBoxResult_SAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SAA.AppendText(" |          |          |" + Environment.NewLine);
                textBoxResult_SAA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format(" |{0,5:d}     |  {1, 5:f2}  |", st, arr[i]);
                    textBoxResult_SAA.AppendText(str + Environment.NewLine);
                    st++;
                }
                textBoxResult_SAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
