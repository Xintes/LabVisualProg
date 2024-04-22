using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Image : Form
    {
        private Bitmap _sourceImage;
        public Image()
        {
            InitializeComponent();
            pictureBox.Visible = false;
            imageMenuItem.Visible = false;
            saveAsMenuItem.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Изображения(*.bmp; *.jpeg; *.jpg|*.bmp; *.jpeg; *.jpg)";
            openFileDialog.ShowDialog();
            _sourceImage = new Bitmap(openFileDialog.FileName);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = _sourceImage;

            this.Width = pictureBox.Width + 40;
            this.Height = pictureBox.Height + 77;
            this.CenterToScreen();

            pictureBox.Visible = true;
            imageMenuItem.Visible = true;
            saveAsMenuItem.Visible = true;
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Изображение BMP|*.bmp|Изображение JPEG|*.jpeg|" + "Изображение JPG|*.jpg";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex) 
                {
                    case 1:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                fs.Close();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filterNewItem_Click(object sender, EventArgs e)
        {
           pictureBox.Image = ImageProcess.FilterImage(_sourceImage);

        }
    }
}
