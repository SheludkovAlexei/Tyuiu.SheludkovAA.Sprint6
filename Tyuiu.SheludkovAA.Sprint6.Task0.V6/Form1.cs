using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task0.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxPerX_SAA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPerX_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPerX_SAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<=47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

    }
}
