using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task4.V23.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-1 Шелудков Алексей Андреевич", "Сведения о работе");
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int st = Convert.ToInt32(textBoxStart_SAA.Text);
                int end = Convert.ToInt32(textBoxStop_SAA.Text);
                string str;
                int len = end - st + 1;
                double[] arr = new double[len];
                arr = ds.GetMassFunction(st, end);
                this.chartResult_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SAA.Text = "";
                chartResult_SAA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_SAA.Series[0].Points.AddXY(st, arr[i]);
                    textBoxResult_SAA.AppendText(arr[i] + Environment.NewLine);
                    st++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsave_Saa_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SAA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно! \n Открыть его?", "Сообщение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

        }
    }
}
