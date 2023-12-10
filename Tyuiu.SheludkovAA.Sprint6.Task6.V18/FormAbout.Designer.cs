
namespace Tyuiu.SheludkovAA.Sprint6.Task6.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAVA_SAA = new System.Windows.Forms.PictureBox();
            this.labelAbout_SAA = new System.Windows.Forms.Label();
            this.buttonOK_SAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAVA_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAVA_SAA
            // 
            this.pictureBoxAVA_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAVA_SAA.Image")));
            this.pictureBoxAVA_SAA.Location = new System.Drawing.Point(27, 29);
            this.pictureBoxAVA_SAA.Name = "pictureBoxAVA_SAA";
            this.pictureBoxAVA_SAA.Size = new System.Drawing.Size(180, 260);
            this.pictureBoxAVA_SAA.TabIndex = 0;
            this.pictureBoxAVA_SAA.TabStop = false;
            // 
            // labelAbout_SAA
            // 
            this.labelAbout_SAA.AutoSize = true;
            this.labelAbout_SAA.Location = new System.Drawing.Point(224, 29);
            this.labelAbout_SAA.Name = "labelAbout_SAA";
            this.labelAbout_SAA.Size = new System.Drawing.Size(151, 65);
            this.labelAbout_SAA.TabIndex = 1;
            this.labelAbout_SAA.Text = "Разработчик: Шелудков А.А.\r\nГруппа: АСОиУб-23-1\r\n\r\nТаск 6 Вариант 18\r\n\r\n";
            // 
            // buttonOK_SAA
            // 
            this.buttonOK_SAA.Location = new System.Drawing.Point(244, 309);
            this.buttonOK_SAA.Name = "buttonOK_SAA";
            this.buttonOK_SAA.Size = new System.Drawing.Size(71, 31);
            this.buttonOK_SAA.TabIndex = 2;
            this.buttonOK_SAA.Text = "Ок";
            this.buttonOK_SAA.UseVisualStyleBackColor = true;
            this.buttonOK_SAA.Click += new System.EventHandler(this.buttonOK_SAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 352);
            this.Controls.Add(this.buttonOK_SAA);
            this.Controls.Add(this.labelAbout_SAA);
            this.Controls.Add(this.pictureBoxAVA_SAA);
            this.MaximumSize = new System.Drawing.Size(409, 391);
            this.MinimumSize = new System.Drawing.Size(409, 391);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAVA_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAVA_SAA;
        private System.Windows.Forms.Label labelAbout_SAA;
        private System.Windows.Forms.Button buttonOK_SAA;
    }
}