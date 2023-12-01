using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

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
                this.chartResult_SAA.Titles.Add("График функции");
                this.chartResult_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
                
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SAA.Rows.Add(Convert.ToString(st), Convert.ToString(arr[i]));
                    this.chartResult_SAA.Series[0].Points.AddXY(st, arr[i]);
                    st++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Шелудков Алексей Андреевич", "Сведения о работе");
        }
    }
}
