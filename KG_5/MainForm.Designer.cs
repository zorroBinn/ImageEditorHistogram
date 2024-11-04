namespace KG_5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadFile_button = new System.Windows.Forms.Button();
            this.gist_R_button = new System.Windows.Forms.Button();
            this.gist_G_button = new System.Windows.Forms.Button();
            this.gist_B_button = new System.Windows.Forms.Button();
            this.gist_Bright_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.label_Brightness = new System.Windows.Forms.Label();
            this.trackBar_Сontrast = new System.Windows.Forms.TrackBar();
            this.label_Сontrast = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Сontrast)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadFile_button
            // 
            this.uploadFile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.uploadFile_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFile_button.ForeColor = System.Drawing.Color.Navy;
            this.uploadFile_button.Location = new System.Drawing.Point(965, 250);
            this.uploadFile_button.Name = "uploadFile_button";
            this.uploadFile_button.Size = new System.Drawing.Size(132, 46);
            this.uploadFile_button.TabIndex = 0;
            this.uploadFile_button.Text = "Upload File";
            this.uploadFile_button.UseVisualStyleBackColor = false;
            // 
            // gist_R_button
            // 
            this.gist_R_button.BackColor = System.Drawing.Color.DarkOrange;
            this.gist_R_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gist_R_button.ForeColor = System.Drawing.Color.Navy;
            this.gist_R_button.Location = new System.Drawing.Point(9, 9);
            this.gist_R_button.Name = "gist_R_button";
            this.gist_R_button.Size = new System.Drawing.Size(48, 34);
            this.gist_R_button.TabIndex = 1;
            this.gist_R_button.Text = "R";
            this.gist_R_button.UseVisualStyleBackColor = false;
            // 
            // gist_G_button
            // 
            this.gist_G_button.BackColor = System.Drawing.Color.DarkOrange;
            this.gist_G_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gist_G_button.ForeColor = System.Drawing.Color.Navy;
            this.gist_G_button.Location = new System.Drawing.Point(63, 9);
            this.gist_G_button.Name = "gist_G_button";
            this.gist_G_button.Size = new System.Drawing.Size(48, 34);
            this.gist_G_button.TabIndex = 2;
            this.gist_G_button.Text = "G";
            this.gist_G_button.UseVisualStyleBackColor = false;
            // 
            // gist_B_button
            // 
            this.gist_B_button.BackColor = System.Drawing.Color.DarkOrange;
            this.gist_B_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gist_B_button.ForeColor = System.Drawing.Color.Navy;
            this.gist_B_button.Location = new System.Drawing.Point(117, 9);
            this.gist_B_button.Name = "gist_B_button";
            this.gist_B_button.Size = new System.Drawing.Size(48, 34);
            this.gist_B_button.TabIndex = 3;
            this.gist_B_button.Text = "B";
            this.gist_B_button.UseVisualStyleBackColor = false;
            // 
            // gist_Bright_button
            // 
            this.gist_Bright_button.BackColor = System.Drawing.Color.DarkOrange;
            this.gist_Bright_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gist_Bright_button.ForeColor = System.Drawing.Color.Navy;
            this.gist_Bright_button.Location = new System.Drawing.Point(171, 9);
            this.gist_Bright_button.Name = "gist_Bright_button";
            this.gist_Bright_button.Size = new System.Drawing.Size(102, 34);
            this.gist_Bright_button.TabIndex = 4;
            this.gist_Bright_button.Text = "Brig";
            this.gist_Bright_button.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gist_Bright_button);
            this.groupBox1.Controls.Add(this.gist_B_button);
            this.groupBox1.Controls.Add(this.gist_G_button);
            this.groupBox1.Controls.Add(this.gist_R_button);
            this.groupBox1.Location = new System.Drawing.Point(889, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // trackBar_Brightness
            // 
            this.trackBar_Brightness.BackColor = System.Drawing.Color.Bisque;
            this.trackBar_Brightness.Location = new System.Drawing.Point(889, 348);
            this.trackBar_Brightness.Maximum = 100;
            this.trackBar_Brightness.Minimum = -100;
            this.trackBar_Brightness.Name = "trackBar_Brightness";
            this.trackBar_Brightness.Size = new System.Drawing.Size(283, 45);
            this.trackBar_Brightness.SmallChange = 5;
            this.trackBar_Brightness.TabIndex = 6;
            this.trackBar_Brightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label_Brightness
            // 
            this.label_Brightness.AutoSize = true;
            this.label_Brightness.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Brightness.ForeColor = System.Drawing.Color.Navy;
            this.label_Brightness.Location = new System.Drawing.Point(893, 318);
            this.label_Brightness.Name = "label_Brightness";
            this.label_Brightness.Size = new System.Drawing.Size(87, 27);
            this.label_Brightness.TabIndex = 7;
            this.label_Brightness.Text = "Яркость";
            // 
            // trackBar_Сontrast
            // 
            this.trackBar_Сontrast.BackColor = System.Drawing.Color.Bisque;
            this.trackBar_Сontrast.Location = new System.Drawing.Point(889, 426);
            this.trackBar_Сontrast.Maximum = 100;
            this.trackBar_Сontrast.Minimum = -100;
            this.trackBar_Сontrast.Name = "trackBar_Сontrast";
            this.trackBar_Сontrast.Size = new System.Drawing.Size(283, 45);
            this.trackBar_Сontrast.SmallChange = 5;
            this.trackBar_Сontrast.TabIndex = 8;
            this.trackBar_Сontrast.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label_Сontrast
            // 
            this.label_Сontrast.AutoSize = true;
            this.label_Сontrast.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Сontrast.ForeColor = System.Drawing.Color.Navy;
            this.label_Сontrast.Location = new System.Drawing.Point(893, 396);
            this.label_Сontrast.Name = "label_Сontrast";
            this.label_Сontrast.Size = new System.Drawing.Size(161, 27);
            this.label_Сontrast.TabIndex = 9;
            this.label_Сontrast.Text = "Контрастность";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label_Сontrast);
            this.Controls.Add(this.trackBar_Сontrast);
            this.Controls.Add(this.label_Brightness);
            this.Controls.Add(this.trackBar_Brightness);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uploadFile_button);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KG_5";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Сontrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFile_button;
        private System.Windows.Forms.Button gist_R_button;
        private System.Windows.Forms.Button gist_G_button;
        private System.Windows.Forms.Button gist_B_button;
        private System.Windows.Forms.Button gist_Bright_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_Brightness;
        private System.Windows.Forms.Label label_Brightness;
        private System.Windows.Forms.TrackBar trackBar_Сontrast;
        private System.Windows.Forms.Label label_Сontrast;
    }
}

