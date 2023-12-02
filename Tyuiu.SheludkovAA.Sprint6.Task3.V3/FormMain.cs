using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SheludkovAA.Sprint6.Task3.V3.Lib;

namespace Tyuiu.SheludkovAA.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtr = new int[5, 5] { { -18 , 21 , 10 ,- 2,  12 },
                                    { -18 ,-10 , 33, -20,  32} ,
                                    {  14 , -15, -14 , 12,-18 },
                                    { -19 ,  5 ,-3 , 28 ,-17 },
                                    { -14 , -9 , 23, -13,  11}};

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtr.GetUpperBound(0) + 1;
            int coll = mtr.Length / rows;
            dataGridViewTask_SAA.ColumnCount = coll;
            dataGridViewTask_SAA.RowCount = rows;

            for (int i = 0; i<coll; i++)
            {
                dataGridViewTask_SAA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewTask_SAA.Rows[i].Cells[j].Value = Convert.ToString(mtr[i, j]);
                }
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Шелудков Алексей Андреевич", "Сведения о работе");
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtr);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridViewResult_SAA.ColumnCount = coll;
            dataGridViewResult_SAA.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewResult_SAA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewResult_SAA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
