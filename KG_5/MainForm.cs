using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KG_5
{
    public partial class MainForm : Form
    {
        private Image originalImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void uploadFile_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image loadedImage = new Bitmap(openFileDialog.FileName);
                        originalImage = (Image)loadedImage.Clone();
                        pictureBox_image.Image = loadedImage;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения.");
                    }
                }
            }
        }

        private void button_GrayShades_Click(object sender, EventArgs e)
        {
            if (pictureBox_image.Image == null) return;
            Bitmap originalBitmap = new Bitmap(pictureBox_image.Image);
            Bitmap grayBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    //Вычисляем значение яркости Y
                    int Y = (int)(0.299 * originalColor.R + 0.5876 * originalColor.G + 0.114 * originalColor.B);
                    //(R = G = B = Y)
                    Color grayColor = Color.FromArgb(Y, Y, Y);
                    grayBitmap.SetPixel(x, y, grayColor);
                }
            }
            pictureBox_image.Image = grayBitmap;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                pictureBox_image.Image = (Image)originalImage.Clone();
                trackBar_Binarization_porog.Value = 128;
                trackBar_Brightness.Value = 0;
                trackBar_Сontrast.Value = 0;
            }
            else return;
        }

        private void button_Negative_Click(object sender, EventArgs e)
        {
            if (pictureBox_image.Image == null) return;
            Bitmap originalBitmap = new Bitmap(pictureBox_image.Image);
            Bitmap negativeBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    //Делаем негатив по всем каналам
                    int negativeR = 255 - originalColor.R;
                    int negativeG = 255 - originalColor.G;
                    int negativeB = 255 - originalColor.B;
                    Color negativeColor = Color.FromArgb(negativeR, negativeG, negativeB);
                    negativeBitmap.SetPixel(x, y, negativeColor);
                }
            }
            pictureBox_image.Image = negativeBitmap;
        }

        private void button_Binarization_Click(object sender, EventArgs e)
        {
            if (pictureBox_image.Image == null) return;
            Bitmap originalBitmap = new Bitmap(pictureBox_image.Image);
            Bitmap binaryBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    //Вычисляем значение яркости Y
                    int Y = (int)(0.299 * originalColor.R + 0.587 * originalColor.G + 0.114 * originalColor.B);
                    //Определяем цвет на основе порога
                    Color binaryColor = Y >= trackBar_Binarization_porog.Value ? Color.White : Color.Black;
                    binaryBitmap.SetPixel(x, y, binaryColor);
                }
            }
            pictureBox_image.Image = binaryBitmap;
        }

        private void gist_R_button_Click(object sender, EventArgs e)
        {
            DrawHistogram(ColorChannel.Red);
        }

        private void gist_G_button_Click(object sender, EventArgs e)
        {
            DrawHistogram(ColorChannel.Green);
        }

        private void gist_B_button_Click(object sender, EventArgs e)
        {
            DrawHistogram(ColorChannel.Blue);
        }

        private void gist_Brightness_button_Click(object sender, EventArgs e)
        {
            DrawHistogram(ColorChannel.Brightness);
        }

        private void DrawHistogram(ColorChannel channel)
        {
            if (pictureBox_image.Image == null) return;
            //Хранение значений гистограммы
            int[] histogram = new int[256];

            Bitmap bitmap = new Bitmap(pictureBox_image.Image);

            //Заполнение массива значениями гистограммы
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int value;
                    switch (channel)
                    {
                        case ColorChannel.Red:
                            value = pixelColor.R;
                            break;
                        case ColorChannel.Green:
                            value = pixelColor.G;
                            break;
                        case ColorChannel.Blue:
                            value = pixelColor.B;
                            break;
                        case ColorChannel.Brightness:
                            value = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                            break;
                        default:
                            value = 0;
                            break;
                    }
                    histogram[value]++;
                }
            }

            gist.Series.Clear();
            var series = new Series("Гистограмма")
            {
                ChartType = SeriesChartType.Column
            };
            gist.Series.Add(series);

            //Заполнение гистограммы
            for (int i = 0; i < histogram.Length; i++)
            {
                series.Points.AddXY(i, histogram[i]);
            }

            gist.ChartAreas[0].AxisX.Title = "Значения (0-255)";
            gist.ChartAreas[0].AxisY.Title = "Частота";
            gist.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            gist.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            gist.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            gist.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            gist.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            gist.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            gist.Titles.Clear();
            gist.Titles.Add("Гистограмма " + channel.ToString());
        }

        public enum ColorChannel
        {
            Red,
            Green,
            Blue,
            Brightness
        }

        private void trackBar_Binarization_porog_ValueChanged(object sender, EventArgs e)
        {
            label_Porog_Count.Text = trackBar_Binarization_porog.Value.ToString();
        }

        private void trackBar_Brightness_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_Brightness.Value > 0)
            {
                label_Bright_Percent.Text = "+" + trackBar_Brightness.Value.ToString() + "%";
            }
            else if (trackBar_Brightness.Value < 0)
            {
                label_Bright_Percent.Text = trackBar_Brightness.Value.ToString() + "%";
            }
            else
            {
                label_Bright_Percent.Text = "0";
            }
        }

        private void trackBar_Сontrast_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_Сontrast.Value > 0)
            {
                label_Contrast_Percent.Text = "+" + trackBar_Сontrast.Value.ToString() + "%";
            }
            else if (trackBar_Сontrast.Value < 0)
            {
                label_Contrast_Percent.Text = trackBar_Сontrast.Value.ToString() + "%";
            }
            else
            {
                label_Contrast_Percent.Text = "0";
            }
        }

        private void AdjustBrightness(int brightnessPercentage)
        {
            if (pictureBox_image.Image == null) return;
            
            Bitmap bitmap = new Bitmap(originalImage);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    //Вычисляем значение яркости Y
                    double Y = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;

                    //Рассчитываем изменение яркости на указанный процент
                    double adjustmentFactor = 1 + (brightnessPercentage / 100.0);
                    double newY = Y * adjustmentFactor;
                    //Пересчитываем новые значения RGB, сохраняя оттенки
                    int newR = (int)Math.Max(0, Math.Min(255, pixelColor.R * adjustmentFactor));
                    int newG = (int)Math.Max(0, Math.Min(255, pixelColor.G * adjustmentFactor));
                    int newB = (int)Math.Max(0, Math.Min(255, pixelColor.B * adjustmentFactor));
                    bitmap.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }
            pictureBox_image.Image = bitmap;
        }

        private void trackBar_Brightness_MouseUp(object sender, MouseEventArgs e)
        {
            AdjustBrightness(trackBar_Brightness.Value);
        }

        private void AdjustContrast(int contrastValue)
        {
            if (pictureBox_image.Image == null) return;

            Bitmap contrastImage = new Bitmap(originalImage);

            //Вычисляем среднюю яркость (Yav) для всего изображения
            double totalBrightness = 0;
            int pixelCount = contrastImage.Width * contrastImage.Height;

            for (int x = 0; x < contrastImage.Width; x++)
            {
                for (int y = 0; y < contrastImage.Height; y++)
                {
                    Color pixelColor = contrastImage.GetPixel(x, y);
                    double Y = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;
                    totalBrightness += Y;
                }
            }
            double averageBrightness = totalBrightness / pixelCount;

            //Определяем коэффициент контрастности K на основе contrastValue
            double contrastFactor = 1 + (contrastValue / 100.0);

            for (int x = 0; x < contrastImage.Width; x++)
            {
                for (int y = 0; y < contrastImage.Height; y++)
                {
                    Color pixelColor = contrastImage.GetPixel(x, y);
                    //Рассчитываем текущую яркость
                    double oldY = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;
                    // Корректируем каждый канал пропорционально
                    int newR = Math.Max(0, Math.Min(255, (int)(contrastFactor * (pixelColor.R - averageBrightness) + averageBrightness)));
                    int newG = Math.Max(0, Math.Min(255, (int)(contrastFactor * (pixelColor.G - averageBrightness) + averageBrightness)));
                    int newB = Math.Max(0, Math.Min(255, (int)(contrastFactor * (pixelColor.B - averageBrightness) + averageBrightness)));
                    contrastImage.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }
            pictureBox_image.Image = contrastImage;
        }

        private void trackBar_Сontrast_MouseUp(object sender, MouseEventArgs e)
        {
            AdjustContrast(trackBar_Сontrast.Value);
        }
    }
}
