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
            if (pictureBox_image.Image == null)
            {
                return;
            }
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
            }
            else
            {
                return;
            }
        }

        private void button_Negative_Click(object sender, EventArgs e)
        {
            if (pictureBox_image.Image == null)
            {
                return;
            }
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
            if (pictureBox_image.Image == null)
            {
                return;
            }
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
                    Color binaryColor = Y >= 128 ? Color.White : Color.Black;
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



    }
}
