using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelRGB
{
    public partial class Form1 : Form
    {
        string fileLocation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Browse Image";
            openFile.Filter = "Choose Image |*jpg;*png";

            if (openFile.ShowDialog() == DialogResult.OK) {
                fileLocation = openFile.FileName;
                Image image = Image.FromFile(fileLocation);

                pictureOriginal.Image = image;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(fileLocation);
            Bitmap RedImage = new Bitmap(fileLocation);
            Bitmap GreenImage = new Bitmap(fileLocation);
            Bitmap BlueImage = new Bitmap(fileLocation);

            int width = originalImage.Width;
            int height = originalImage.Height;

            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {
                    Color c = originalImage.GetPixel(x, y);

                    int alpha = c.A;
                    int red = c.R;
                    int green = c.G;
                    int blue = c.B;

                    RedImage.SetPixel(x, y, Color.FromArgb(alpha,red,0,0));
                    GreenImage.SetPixel(x, y, Color.FromArgb(alpha, 0, green, 0));
                    BlueImage.SetPixel(x, y, Color.FromArgb(alpha, 0, 0, blue));
                }
            }

            pictureRed.Image = RedImage;
            pictureGreen.Image = GreenImage;
            pictureBlue.Image = BlueImage;
        }
    }
}
