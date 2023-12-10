
namespace Tyuiu.SheludkovAA.Sprint6.Task6.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_SAA = new System.Windows.Forms.Panel();
            this.panelText_SAA = new System.Windows.Forms.Panel();
            this.panelResult_SAA = new System.Windows.Forms.Panel();
            this.panelTask_SAA = new System.Windows.Forms.Panel();
            this.buttonOpen_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxText_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.textBoxText_SAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDone = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_SAA.SuspendLayout();
            this.panelText_SAA.SuspendLayout();
            this.panelResult_SAA.SuspendLayout();
            this.panelTask_SAA.SuspendLayout();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxText_SAA.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_SAA
            // 
            this.panelButtons_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelButtons_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelButtons_SAA.Controls.Add(this.buttonOpen_SAA);
            this.panelButtons_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_SAA.Name = "panelButtons_SAA";
            this.panelButtons_SAA.Size = new System.Drawing.Size(800, 87);
            this.panelButtons_SAA.TabIndex = 0;
            // 
            // panelText_SAA
            // 
            this.panelText_SAA.Controls.Add(this.groupBoxText_SAA);
            this.panelText_SAA.Location = new System.Drawing.Point(0, 182);
            this.panelText_SAA.Name = "panelText_SAA";
            this.panelText_SAA.Size = new System.Drawing.Size(379, 378);
            this.panelText_SAA.TabIndex = 1;
            // 
            // panelResult_SAA
            // 
            this.panelResult_SAA.Controls.Add(this.groupBoxResult);
            this.panelResult_SAA.Location = new System.Drawing.Point(376, 182);
            this.panelResult_SAA.Name = "panelResult_SAA";
            this.panelResult_SAA.Size = new System.Drawing.Size(424, 378);
            this.panelResult_SAA.TabIndex = 2;
            // 
            // panelTask_SAA
            // 
            this.panelTask_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelTask_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SAA.Location = new System.Drawing.Point(0, 87);
            this.panelTask_SAA.Name = "panelTask_SAA";
            this.panelTask_SAA.Size = new System.Drawing.Size(800, 94);
            this.panelTask_SAA.TabIndex = 3;
            // 
            // buttonOpen_SAA
            // 
            this.buttonOpen_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SAA.Image")));
            this.buttonOpen_SAA.Location = new System.Drawing.Point(12, 5);
            this.buttonOpen_SAA.Name = "buttonOpen_SAA";
            this.buttonOpen_SAA.Size = new System.Drawing.Size(92, 76);
            this.buttonOpen_SAA.TabIndex = 0;
            this.buttonOpen_SAA.UseVisualStyleBackColor = true;
            this.buttonOpen_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAA.Image")));
            this.buttonDone_SAA.Location = new System.Drawing.Point(119, 5);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(92, 76);
            this.buttonDone_SAA.TabIndex = 1;
            this.toolTipDone.SetToolTip(this.buttonDone_SAA, "Coins + +");
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(800, 91);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // groupBoxText_SAA
            // 
            this.groupBoxText_SAA.Controls.Add(this.textBoxText_SAA);
            this.groupBoxText_SAA.Location = new System.Drawing.Point(6, 2);
            this.groupBoxText_SAA.Name = "groupBoxText_SAA";
            this.groupBoxText_SAA.Size = new System.Drawing.Size(364, 375);
            this.groupBoxText_SAA.TabIndex = 0;
            this.groupBoxText_SAA.TabStop = false;
            this.groupBoxText_SAA.Text = "Ввод: ";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxResult.Location = new System.Drawing.Point(6, 3);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(415, 373);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.Location = new System.Drawing.Point(12, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(776, 66);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            // 
            // textBoxText_SAA
            // 
            this.textBoxText_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxText_SAA.Multiline = true;
            this.textBoxText_SAA.Name = "textBoxText_SAA";
            this.textBoxText_SAA.Size = new System.Drawing.Size(352, 345);
            this.textBoxText_SAA.TabIndex = 0;
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.Size = new System.Drawing.Size(403, 344);
            this.textBoxResult_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAA.Image")));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(699, 5);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(92, 76);
            this.buttonHelp_SAA.TabIndex = 2;
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipDone
            // 
            this.toolTipDone.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipDone.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panelTask_SAA);
            this.Controls.Add(this.panelResult_SAA);
            this.Controls.Add(this.panelText_SAA);
            this.Controls.Add(this.panelButtons_SAA);
            this.MinimumSize = new System.Drawing.Size(816, 599);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Шелудков А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_SAA.ResumeLayout(false);
            this.panelText_SAA.ResumeLayout(false);
            this.panelResult_SAA.ResumeLayout(false);
            this.panelTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxText_SAA.ResumeLayout(false);
            this.groupBoxText_SAA.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SAA;
        private System.Windows.Forms.Panel panelText_SAA;
        private System.Windows.Forms.Panel panelResult_SAA;
        private System.Windows.Forms.Panel panelTask_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonOpen_SAA;
        private System.Windows.Forms.GroupBox groupBoxText_SAA;
        private System.Windows.Forms.TextBox textBoxText_SAA;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipDone;
    }
}

