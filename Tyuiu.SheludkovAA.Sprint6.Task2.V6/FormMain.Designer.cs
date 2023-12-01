
namespace Tyuiu.SheludkovAA.Sprint6.Task2.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_SAA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_SAA = new System.Windows.Forms.GroupBox();
            this.labelEnd_SAA = new System.Windows.Forms.Label();
            this.labelStart_SAA = new System.Windows.Forms.Label();
            this.textBoxEnd_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAA = new System.Windows.Forms.TextBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SAA)).BeginInit();
            this.groupBoxVar_SAA.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.pictureBoxTask_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(19, 13);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(506, 201);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // pictureBoxTask_SAA
            // 
            this.pictureBoxTask_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_SAA.Image")));
            this.pictureBoxTask_SAA.Location = new System.Drawing.Point(107, 128);
            this.pictureBoxTask_SAA.Name = "pictureBoxTask_SAA";
            this.pictureBoxTask_SAA.Size = new System.Drawing.Size(312, 40);
            this.pictureBoxTask_SAA.TabIndex = 1;
            this.pictureBoxTask_SAA.TabStop = false;
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Enabled = false;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(22, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(464, 95);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Написать программу, которая выводит таблицу значений функции :";
            // 
            // groupBoxVar_SAA
            // 
            this.groupBoxVar_SAA.Controls.Add(this.labelEnd_SAA);
            this.groupBoxVar_SAA.Controls.Add(this.labelStart_SAA);
            this.groupBoxVar_SAA.Controls.Add(this.textBoxEnd_SAA);
            this.groupBoxVar_SAA.Controls.Add(this.textBoxStart_SAA);
            this.groupBoxVar_SAA.Location = new System.Drawing.Point(19, 232);
            this.groupBoxVar_SAA.Name = "groupBoxVar_SAA";
            this.groupBoxVar_SAA.Size = new System.Drawing.Size(324, 78);
            this.groupBoxVar_SAA.TabIndex = 1;
            this.groupBoxVar_SAA.TabStop = false;
            this.groupBoxVar_SAA.Text = "Ввод данных";
            // 
            // labelEnd_SAA
            // 
            this.labelEnd_SAA.AutoSize = true;
            this.labelEnd_SAA.Location = new System.Drawing.Point(169, 28);
            this.labelEnd_SAA.Name = "labelEnd_SAA";
            this.labelEnd_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_SAA.TabIndex = 3;
            this.labelEnd_SAA.Text = "Конец шага:";
            // 
            // labelStart_SAA
            // 
            this.labelStart_SAA.AutoSize = true;
            this.labelStart_SAA.Location = new System.Drawing.Point(17, 28);
            this.labelStart_SAA.Name = "labelStart_SAA";
            this.labelStart_SAA.Size = new System.Drawing.Size(75, 13);
            this.labelStart_SAA.TabIndex = 2;
            this.labelStart_SAA.Text = "Начало шага:";
            // 
            // textBoxEnd_SAA
            // 
            this.textBoxEnd_SAA.Location = new System.Drawing.Point(172, 44);
            this.textBoxEnd_SAA.Name = "textBoxEnd_SAA";
            this.textBoxEnd_SAA.Size = new System.Drawing.Size(126, 20);
            this.textBoxEnd_SAA.TabIndex = 1;
            // 
            // textBoxStart_SAA
            // 
            this.textBoxStart_SAA.Location = new System.Drawing.Point(20, 44);
            this.textBoxStart_SAA.Name = "textBoxStart_SAA";
            this.textBoxStart_SAA.Size = new System.Drawing.Size(126, 20);
            this.textBoxStart_SAA.TabIndex = 0;
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone_SAA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDone_SAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDone_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_SAA.Location = new System.Drawing.Point(453, 252);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(72, 47);
            this.buttonDone_SAA.TabIndex = 2;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonHelp_SAA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(368, 255);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(70, 41);
            this.buttonHelp_SAA.TabIndex = 3;
            this.buttonHelp_SAA.Text = "Сведения";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.chartResult_SAA);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxResult.Location = new System.Drawing.Point(546, 13);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(540, 297);
            this.groupBoxResult.TabIndex = 4;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(16, 26);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.ReadOnly = true;
            this.dataGridViewResult_SAA.RowHeadersVisible = false;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(109, 240);
            this.dataGridViewResult_SAA.TabIndex = 0;
            // 
            // X
            // 
            this.X.FillWeight = 50F;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.FillWeight = 50F;
            this.F.HeaderText = "F(x)";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // chartResult_SAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_SAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_SAA.Legends.Add(legend2);
            this.chartResult_SAA.Location = new System.Drawing.Point(146, 26);
            this.chartResult_SAA.Name = "chartResult_SAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "F(x)";
            this.chartResult_SAA.Series.Add(series2);
            this.chartResult_SAA.Size = new System.Drawing.Size(377, 240);
            this.chartResult_SAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 318);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxVar_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 6 | Шелудков А.А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SAA)).EndInit();
            this.groupBoxVar_SAA.ResumeLayout(false);
            this.groupBoxVar_SAA.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxVar_SAA;
        private System.Windows.Forms.Label labelEnd_SAA;
        private System.Windows.Forms.Label labelStart_SAA;
        private System.Windows.Forms.TextBox textBoxEnd_SAA;
        private System.Windows.Forms.TextBox textBoxStart_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

