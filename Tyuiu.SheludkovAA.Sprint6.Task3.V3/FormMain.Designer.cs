
namespace Tyuiu.SheludkovAA.Sprint6.Task3.V3
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
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.dataGridViewTask_SAA = new System.Windows.Forms.DataGridView();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxResult_SAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.labelResult_SAA = new System.Windows.Forms.Label();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_SAA)).BeginInit();
            this.groupBoxResult_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxTask_SAA.Controls.Add(this.labelTask);
            this.groupBoxTask_SAA.Controls.Add(this.dataGridViewTask_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(9, 15);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(515, 267);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Enabled = false;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(12, 25);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(262, 212);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            // 
            // dataGridViewTask_SAA
            // 
            this.dataGridViewTask_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_SAA.ColumnHeadersVisible = false;
            this.dataGridViewTask_SAA.Location = new System.Drawing.Point(326, 64);
            this.dataGridViewTask_SAA.Name = "dataGridViewTask_SAA";
            this.dataGridViewTask_SAA.ReadOnly = true;
            this.dataGridViewTask_SAA.RowHeadersVisible = false;
            this.dataGridViewTask_SAA.Size = new System.Drawing.Size(171, 153);
            this.dataGridViewTask_SAA.TabIndex = 1;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(386, 48);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(51, 13);
            this.labelTask.TabIndex = 2;
            this.labelTask.Text = "Матрица";
            // 
            // groupBoxResult_SAA
            // 
            this.groupBoxResult_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxResult_SAA.Controls.Add(this.labelResult_SAA);
            this.groupBoxResult_SAA.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxResult_SAA.Location = new System.Drawing.Point(546, 15);
            this.groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            this.groupBoxResult_SAA.Size = new System.Drawing.Size(231, 267);
            this.groupBoxResult_SAA.TabIndex = 1;
            this.groupBoxResult_SAA.TabStop = false;
            this.groupBoxResult_SAA.Text = "Результат";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone_SAA.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonDone_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SAA.Location = new System.Drawing.Point(24, 306);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(237, 55);
            this.buttonDone_SAA.TabIndex = 2;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHelp_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(291, 306);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(119, 54);
            this.buttonHelp_SAA.TabIndex = 3;
            this.buttonHelp_SAA.Text = "Сведения";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(32, 65);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.ReadOnly = true;
            this.dataGridViewResult_SAA.RowHeadersVisible = false;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(171, 152);
            this.dataGridViewResult_SAA.TabIndex = 0;
            // 
            // labelResult_SAA
            // 
            this.labelResult_SAA.AutoSize = true;
            this.labelResult_SAA.Location = new System.Drawing.Point(90, 48);
            this.labelResult_SAA.Name = "labelResult_SAA";
            this.labelResult_SAA.Size = new System.Drawing.Size(51, 13);
            this.labelResult_SAA.TabIndex = 1;
            this.labelResult_SAA.Text = "Матрица";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxResult_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 3 | Шелудков А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_SAA)).EndInit();
            this.groupBoxResult_SAA.ResumeLayout(false);
            this.groupBoxResult_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.DataGridView dataGridViewTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxResult_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Label labelResult_SAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
    }
}

