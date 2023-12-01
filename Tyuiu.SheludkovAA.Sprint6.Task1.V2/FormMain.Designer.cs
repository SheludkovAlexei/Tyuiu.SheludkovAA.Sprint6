
namespace Tyuiu.SheludkovAA.Sprint6.Task1.V2
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
            this.pictureBoxTask_SAA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxPer_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAA = new System.Windows.Forms.TextBox();
            this.labelStart_SAA = new System.Windows.Forms.Label();
            this.labelEnd_SAA = new System.Windows.Forms.Label();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxResult_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SAA)).BeginInit();
            this.groupBoxPer_SAA.SuspendLayout();
            this.groupBoxResult_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.pictureBoxTask_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(16, 10);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(494, 225);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // pictureBoxTask_SAA
            // 
            this.pictureBoxTask_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_SAA.Image")));
            this.pictureBoxTask_SAA.Location = new System.Drawing.Point(124, 154);
            this.pictureBoxTask_SAA.Name = "pictureBoxTask_SAA";
            this.pictureBoxTask_SAA.Size = new System.Drawing.Size(248, 41);
            this.pictureBoxTask_SAA.TabIndex = 1;
            this.pictureBoxTask_SAA.TabStop = false;
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Enabled = false;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(13, 25);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(466, 104);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Написать программу, которая выводит таблицу значений функции :";
            // 
            // groupBoxPer_SAA
            // 
            this.groupBoxPer_SAA.Controls.Add(this.labelEnd_SAA);
            this.groupBoxPer_SAA.Controls.Add(this.labelStart_SAA);
            this.groupBoxPer_SAA.Controls.Add(this.textBoxEnd_SAA);
            this.groupBoxPer_SAA.Controls.Add(this.textBoxStart_SAA);
            this.groupBoxPer_SAA.Location = new System.Drawing.Point(16, 241);
            this.groupBoxPer_SAA.Name = "groupBoxPer_SAA";
            this.groupBoxPer_SAA.Size = new System.Drawing.Size(262, 79);
            this.groupBoxPer_SAA.TabIndex = 1;
            this.groupBoxPer_SAA.TabStop = false;
            this.groupBoxPer_SAA.Text = "Ввод данных";
            // 
            // textBoxEnd_SAA
            // 
            this.textBoxEnd_SAA.Location = new System.Drawing.Point(141, 49);
            this.textBoxEnd_SAA.Name = "textBoxEnd_SAA";
            this.textBoxEnd_SAA.Size = new System.Drawing.Size(102, 20);
            this.textBoxEnd_SAA.TabIndex = 1;
            // 
            // textBoxStart_SAA
            // 
            this.textBoxStart_SAA.AccessibleDescription = "";
            this.textBoxStart_SAA.AccessibleName = "";
            this.textBoxStart_SAA.Location = new System.Drawing.Point(17, 49);
            this.textBoxStart_SAA.Name = "textBoxStart_SAA";
            this.textBoxStart_SAA.Size = new System.Drawing.Size(95, 20);
            this.textBoxStart_SAA.TabIndex = 0;
            this.textBoxStart_SAA.Tag = "";
            // 
            // labelStart_SAA
            // 
            this.labelStart_SAA.AutoSize = true;
            this.labelStart_SAA.Location = new System.Drawing.Point(14, 33);
            this.labelStart_SAA.Name = "labelStart_SAA";
            this.labelStart_SAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SAA.TabIndex = 2;
            this.labelStart_SAA.Text = "Старт шага:";
            // 
            // labelEnd_SAA
            // 
            this.labelEnd_SAA.AutoSize = true;
            this.labelEnd_SAA.Location = new System.Drawing.Point(138, 33);
            this.labelEnd_SAA.Name = "labelEnd_SAA";
            this.labelEnd_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_SAA.TabIndex = 3;
            this.labelEnd_SAA.Text = "Конец шага:";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone_SAA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone_SAA.FlatAppearance.BorderSize = 5;
            this.buttonDone_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_SAA.Location = new System.Drawing.Point(16, 338);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(262, 57);
            this.buttonDone_SAA.TabIndex = 2;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // groupBoxResult_SAA
            // 
            this.groupBoxResult_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxResult_SAA.Location = new System.Drawing.Point(548, 10);
            this.groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            this.groupBoxResult_SAA.Size = new System.Drawing.Size(240, 384);
            this.groupBoxResult_SAA.TabIndex = 3;
            this.groupBoxResult_SAA.TabStop = false;
            this.groupBoxResult_SAA.Text = "Результат";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(228, 357);
            this.textBoxResult_SAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.groupBoxResult_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxPer_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Шелудков А.А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SAA)).EndInit();
            this.groupBoxPer_SAA.ResumeLayout(false);
            this.groupBoxPer_SAA.PerformLayout();
            this.groupBoxResult_SAA.ResumeLayout(false);
            this.groupBoxResult_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxPer_SAA;
        private System.Windows.Forms.TextBox textBoxEnd_SAA;
        private System.Windows.Forms.TextBox textBoxStart_SAA;
        private System.Windows.Forms.Label labelEnd_SAA;
        private System.Windows.Forms.Label labelStart_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.GroupBox groupBoxResult_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
    }
}

