using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace watermarker
{
    public partial class Watermarker : Form
    {

        private Bitmap LoadImg;
        private Bitmap WatermarkImg;
        private Bitmap SaveImg;
        private float WatermarkAngle = (float)15;

        public Watermarker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = SourceImg_label;
            WatermarkImg = (Bitmap)WatermarkImg_pictureBox.Image;
            numericUpDown.Value = new decimal(WatermarkAngle);
        }

        private void LoadImg_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (LoadImg != null)
                    LoadImg.Dispose();

                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;

                LoadImg = new Bitmap(image, width, height);
                SourceImg_pictureBox.Image = LoadImg;
            }
        }

        private void LoadWatermarkImg_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (WatermarkImg != null)
                    WatermarkImg.Dispose();

                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;

                WatermarkImg = new Bitmap(image, width, height);
                WatermarkImg_pictureBox.Image = WatermarkImg;
            }
        }

        private void SaveImg_button_Click(object sender, EventArgs e)
        {
            if (SaveImg == null)
            {
                MessageBox.Show("No image to save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png)";

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                DestinationImg_pictureBox.Image.Save(fileName);
            }
        }

        private void WatermarkIt_button_Click(object sender, EventArgs e)
        {
            if (LoadImg == null || WatermarkImg == null) {
                MessageBox.Show("No image to watermark!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var graphics = Graphics.FromImage(LoadImg);
            graphics.RotateTransform(WatermarkAngle);
            int y = -LoadImg.Height;
            int x;
            int even = 0;

            while (y < LoadImg.Height * 2) {
                x = 0;
                if (even % 2 == 0)
                    x += WatermarkImg.Width;
                while (x < LoadImg.Width * 2)
                {
                    graphics.DrawImage(WatermarkImg, x, y, WatermarkImg.Width, WatermarkImg.Height);
                    x += WatermarkImg.Width + WatermarkImg.Width;
                }
                y += WatermarkImg.Height + WatermarkImg.Height / 3;
                even++;
            }

            SaveImg = new Bitmap(LoadImg.Width, LoadImg.Height, graphics);
            DestinationImg_pictureBox.Image = LoadImg;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            WatermarkAngle = (float)numericUpDown.Value;
        }
    }
}
