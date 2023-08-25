using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTH2023072_003
{
    public partial class Form1 : Form
    {
        private Image loadedImage;
        private Bitmap drawingBitmap;
        private Graphics drawingGraphics;
        private Pen currentPen;

        public Form1()
        {
            InitializeComponent();

            drawingBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            currentPen = new Pen(Color.Black, 2);

            drawingGraphics.Clear(Color.White);
            pictureBox.Image = drawingBitmap;
        }

        private void loadImageButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedImage = Image.FromFile(openFileDialog.FileName);
                drawingGraphics.DrawImage(loadedImage, Point.Empty);
                pictureBox.Refresh();
            }
        }

        private void colorButton_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentPen.Color = colorDialog.Color;
            }
        }

        private void thicknessTrackBar_Scroll_1(object sender, EventArgs e)
        {
            currentPen.Width = thicknessTrackBar.Value;

            MessageBox.Show($"Pen thickness set to: {currentPen.Width}");
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show($"Mouse Down at X: {e.X}, Y: {e.Y}");
                drawingGraphics.DrawLine(currentPen, e.X, e.Y, e.X, e.Y);
                pictureBox.Refresh();
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                drawingBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

    }
}
