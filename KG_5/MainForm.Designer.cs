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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uploadFile_button = new System.Windows.Forms.Button();
            this.gist_R_button = new System.Windows.Forms.Button();
            this.gist_G_button = new System.Windows.Forms.Button();
            this.gist_B_button = new System.Windows.Forms.Button();
            this.gist_Brightness_button = new System.Windows.Forms.Button();
            this.groupBox_gist = new System.Windows.Forms.GroupBox();
            this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.label_Brightness = new System.Windows.Forms.Label();
            this.trackBar_Сontrast = new System.Windows.Forms.TrackBar();
            this.label_Сontrast = new System.Windows.Forms.Label();
            this.button_Binarization = new System.Windows.Forms.Button();
            this.button_GrayShades = new System.Windows.Forms.Button();
            this.button_Negative = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.gist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar_Binarization_porog = new System.Windows.Forms.TrackBar();
            this.label_porog = new System.Windows.Forms.Label();
            this.label_Bright_Percent = new System.Windows.Forms.Label();
            this.label_Contrast_Percent = new System.Windows.Forms.Label();
            this.label_Porog_Count = new System.Windows.Forms.Label();
            this.groupBox_gist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Сontrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Binarization_porog)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadFile_button
            // 
            this.uploadFile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.uploadFile_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFile_button.ForeColor = System.Drawing.Color.Navy;
            this.uploadFile_button.Location = new System.Drawing.Point(952, 250);
            this.uploadFile_button.Name = "uploadFile_button";
            this.uploadFile_button.Size = new System.Drawing.Size(143, 65);
            this.uploadFile_button.TabIndex = 0;
            this.uploadFile_button.Text = "Загрузить файл";
            this.uploadFile_button.UseVisualStyleBackColor = false;
            this.uploadFile_button.Click += new System.EventHandler(this.uploadFile_button_Click);
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
            this.gist_R_button.Click += new System.EventHandler(this.gist_R_button_Click);
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
            this.gist_G_button.Click += new System.EventHandler(this.gist_G_button_Click);
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
            this.gist_B_button.Click += new System.EventHandler(this.gist_B_button_Click);
            // 
            // gist_Brightness_button
            // 
            this.gist_Brightness_button.BackColor = System.Drawing.Color.DarkOrange;
            this.gist_Brightness_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gist_Brightness_button.ForeColor = System.Drawing.Color.Navy;
            this.gist_Brightness_button.Location = new System.Drawing.Point(171, 9);
            this.gist_Brightness_button.Name = "gist_Brightness_button";
            this.gist_Brightness_button.Size = new System.Drawing.Size(102, 34);
            this.gist_Brightness_button.TabIndex = 4;
            this.gist_Brightness_button.Text = "Bright";
            this.gist_Brightness_button.UseVisualStyleBackColor = false;
            this.gist_Brightness_button.Click += new System.EventHandler(this.gist_Brightness_button_Click);
            // 
            // groupBox_gist
            // 
            this.groupBox_gist.Controls.Add(this.gist_Brightness_button);
            this.groupBox_gist.Controls.Add(this.gist_B_button);
            this.groupBox_gist.Controls.Add(this.gist_G_button);
            this.groupBox_gist.Controls.Add(this.gist_R_button);
            this.groupBox_gist.Location = new System.Drawing.Point(889, 193);
            this.groupBox_gist.Name = "groupBox_gist";
            this.groupBox_gist.Size = new System.Drawing.Size(283, 51);
            this.groupBox_gist.TabIndex = 5;
            this.groupBox_gist.TabStop = false;
            // 
            // trackBar_Brightness
            // 
            this.trackBar_Brightness.BackColor = System.Drawing.Color.Linen;
            this.trackBar_Brightness.Location = new System.Drawing.Point(889, 348);
            this.trackBar_Brightness.Maximum = 100;
            this.trackBar_Brightness.Minimum = -100;
            this.trackBar_Brightness.Name = "trackBar_Brightness";
            this.trackBar_Brightness.Size = new System.Drawing.Size(283, 45);
            this.trackBar_Brightness.SmallChange = 5;
            this.trackBar_Brightness.TabIndex = 6;
            this.trackBar_Brightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_Brightness.ValueChanged += new System.EventHandler(this.trackBar_Brightness_ValueChanged);
            this.trackBar_Brightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Brightness_MouseUp);
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
            this.trackBar_Сontrast.BackColor = System.Drawing.Color.Linen;
            this.trackBar_Сontrast.Location = new System.Drawing.Point(889, 426);
            this.trackBar_Сontrast.Maximum = 100;
            this.trackBar_Сontrast.Minimum = -100;
            this.trackBar_Сontrast.Name = "trackBar_Сontrast";
            this.trackBar_Сontrast.Size = new System.Drawing.Size(283, 45);
            this.trackBar_Сontrast.SmallChange = 5;
            this.trackBar_Сontrast.TabIndex = 8;
            this.trackBar_Сontrast.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_Сontrast.ValueChanged += new System.EventHandler(this.trackBar_Сontrast_ValueChanged);
            this.trackBar_Сontrast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Сontrast_MouseUp);
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
            // button_Binarization
            // 
            this.button_Binarization.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Binarization.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Binarization.ForeColor = System.Drawing.Color.Navy;
            this.button_Binarization.Location = new System.Drawing.Point(1019, 477);
            this.button_Binarization.Name = "button_Binarization";
            this.button_Binarization.Size = new System.Drawing.Size(143, 46);
            this.button_Binarization.TabIndex = 10;
            this.button_Binarization.Text = "Бинаризация";
            this.button_Binarization.UseVisualStyleBackColor = false;
            this.button_Binarization.Click += new System.EventHandler(this.button_Binarization_Click);
            // 
            // button_GrayShades
            // 
            this.button_GrayShades.BackColor = System.Drawing.Color.DarkOrange;
            this.button_GrayShades.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GrayShades.ForeColor = System.Drawing.Color.Navy;
            this.button_GrayShades.Location = new System.Drawing.Point(1019, 580);
            this.button_GrayShades.Name = "button_GrayShades";
            this.button_GrayShades.Size = new System.Drawing.Size(143, 62);
            this.button_GrayShades.TabIndex = 11;
            this.button_GrayShades.Text = "Оттенки серого";
            this.button_GrayShades.UseVisualStyleBackColor = false;
            this.button_GrayShades.Click += new System.EventHandler(this.button_GrayShades_Click);
            // 
            // button_Negative
            // 
            this.button_Negative.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Negative.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Negative.ForeColor = System.Drawing.Color.Navy;
            this.button_Negative.Location = new System.Drawing.Point(1019, 648);
            this.button_Negative.Name = "button_Negative";
            this.button_Negative.Size = new System.Drawing.Size(143, 46);
            this.button_Negative.TabIndex = 12;
            this.button_Negative.Text = "Негатив";
            this.button_Negative.UseVisualStyleBackColor = false;
            this.button_Negative.Click += new System.EventHandler(this.button_Negative_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.ForeColor = System.Drawing.Color.Navy;
            this.button_Reset.Location = new System.Drawing.Point(1019, 700);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(143, 46);
            this.button_Reset.TabIndex = 13;
            this.button_Reset.Text = "Сброс";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(871, 737);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 14;
            this.pictureBox_image.TabStop = false;
            // 
            // gist
            // 
            this.gist.BackColor = System.Drawing.SystemColors.Control;
            this.gist.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.gist.ChartAreas.Add(chartArea1);
            this.gist.Location = new System.Drawing.Point(889, 12);
            this.gist.Name = "gist";
            this.gist.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.gist.Series.Add(series1);
            this.gist.Size = new System.Drawing.Size(283, 184);
            this.gist.TabIndex = 16;
            this.gist.Text = "chart1";
            // 
            // trackBar_Binarization_porog
            // 
            this.trackBar_Binarization_porog.BackColor = System.Drawing.Color.Linen;
            this.trackBar_Binarization_porog.LargeChange = 1;
            this.trackBar_Binarization_porog.Location = new System.Drawing.Point(963, 529);
            this.trackBar_Binarization_porog.Maximum = 255;
            this.trackBar_Binarization_porog.Minimum = 1;
            this.trackBar_Binarization_porog.Name = "trackBar_Binarization_porog";
            this.trackBar_Binarization_porog.Size = new System.Drawing.Size(209, 45);
            this.trackBar_Binarization_porog.TabIndex = 17;
            this.trackBar_Binarization_porog.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_Binarization_porog.Value = 128;
            this.trackBar_Binarization_porog.ValueChanged += new System.EventHandler(this.trackBar_Binarization_porog_ValueChanged);
            // 
            // label_porog
            // 
            this.label_porog.AutoSize = true;
            this.label_porog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_porog.ForeColor = System.Drawing.Color.Navy;
            this.label_porog.Location = new System.Drawing.Point(889, 520);
            this.label_porog.Name = "label_porog";
            this.label_porog.Size = new System.Drawing.Size(68, 27);
            this.label_porog.TabIndex = 18;
            this.label_porog.Text = "Порог";
            // 
            // label_Bright_Percent
            // 
            this.label_Bright_Percent.AutoSize = true;
            this.label_Bright_Percent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Bright_Percent.ForeColor = System.Drawing.Color.Navy;
            this.label_Bright_Percent.Location = new System.Drawing.Point(986, 318);
            this.label_Bright_Percent.Name = "label_Bright_Percent";
            this.label_Bright_Percent.Size = new System.Drawing.Size(48, 27);
            this.label_Bright_Percent.TabIndex = 19;
            this.label_Bright_Percent.Text = "0 %";
            // 
            // label_Contrast_Percent
            // 
            this.label_Contrast_Percent.AutoSize = true;
            this.label_Contrast_Percent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Contrast_Percent.ForeColor = System.Drawing.Color.Navy;
            this.label_Contrast_Percent.Location = new System.Drawing.Point(1060, 396);
            this.label_Contrast_Percent.Name = "label_Contrast_Percent";
            this.label_Contrast_Percent.Size = new System.Drawing.Size(48, 27);
            this.label_Contrast_Percent.TabIndex = 20;
            this.label_Contrast_Percent.Text = "0 %";
            // 
            // label_Porog_Count
            // 
            this.label_Porog_Count.AutoSize = true;
            this.label_Porog_Count.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Porog_Count.ForeColor = System.Drawing.Color.Navy;
            this.label_Porog_Count.Location = new System.Drawing.Point(898, 547);
            this.label_Porog_Count.Name = "label_Porog_Count";
            this.label_Porog_Count.Size = new System.Drawing.Size(48, 27);
            this.label_Porog_Count.TabIndex = 21;
            this.label_Porog_Count.Text = "128";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label_Porog_Count);
            this.Controls.Add(this.label_Contrast_Percent);
            this.Controls.Add(this.label_Bright_Percent);
            this.Controls.Add(this.label_porog);
            this.Controls.Add(this.trackBar_Binarization_porog);
            this.Controls.Add(this.gist);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Negative);
            this.Controls.Add(this.button_GrayShades);
            this.Controls.Add(this.button_Binarization);
            this.Controls.Add(this.label_Сontrast);
            this.Controls.Add(this.trackBar_Сontrast);
            this.Controls.Add(this.label_Brightness);
            this.Controls.Add(this.trackBar_Brightness);
            this.Controls.Add(this.groupBox_gist);
            this.Controls.Add(this.uploadFile_button);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KG_5";
            this.groupBox_gist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Сontrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Binarization_porog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFile_button;
        private System.Windows.Forms.Button gist_R_button;
        private System.Windows.Forms.Button gist_G_button;
        private System.Windows.Forms.Button gist_B_button;
        private System.Windows.Forms.Button gist_Brightness_button;
        private System.Windows.Forms.GroupBox groupBox_gist;
        private System.Windows.Forms.TrackBar trackBar_Brightness;
        private System.Windows.Forms.Label label_Brightness;
        private System.Windows.Forms.TrackBar trackBar_Сontrast;
        private System.Windows.Forms.Label label_Сontrast;
        private System.Windows.Forms.Button button_Binarization;
        private System.Windows.Forms.Button button_GrayShades;
        private System.Windows.Forms.Button button_Negative;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.DataVisualization.Charting.Chart gist;
        private System.Windows.Forms.TrackBar trackBar_Binarization_porog;
        private System.Windows.Forms.Label label_porog;
        private System.Windows.Forms.Label label_Bright_Percent;
        private System.Windows.Forms.Label label_Contrast_Percent;
        private System.Windows.Forms.Label label_Porog_Count;
    }
}

