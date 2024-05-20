using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traseu
{
    public partial class Form1 : Form
    {
        Image Harta, img;
        Graphics g1, g;
        float latime = 900, inaltime = 500;
        private string FilePath = String.Concat(System.IO.Directory.GetCurrentDirectory() + "\\resurse\\traseu.txt");
        private string ImagePath = String.Concat(System.IO.Directory.GetCurrentDirectory() + "\\resurse\\harta.bmp");


        public Form1()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void afiseazaHartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(ImagePath);
            harta.Image = img;
            harta.Refresh();
        }

        private void traseuButton_Click(object sender, EventArgs e)
        {
            var coordinates = ReadCoordinatesFromFile(FilePath);
            if (coordinates.Count > 1)
            {
                DrawLines(coordinates);
            }
            else
            {
                MessageBox.Show("The file does not contain enough coordinates to draw lines.");
            }
        }

        private List<(Point Point, string Text)> ReadCoordinatesFromFile(string filePath)
        {
            var points = new List<(Point, string)>();

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',').Select(part => part.Trim()).ToArray();
                if (parts.Length == 3 &&
                    int.TryParse(parts[0].Split('=')[1], out int x) &&
                    int.TryParse(parts[1].Split('=')[1], out int y))
                {
                    string text = parts[2].Split('=')[1].Trim('"');
                    points.Add((new Point(x, y), text));
                }
            }

            return points;
        }

        private void DrawLines(List<(Point Point, string Text)> points)
        {
            try
            {
                Bitmap background = new Bitmap(ImagePath);
                using (Graphics g = Graphics.FromImage(background))
                {
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        g.DrawLine(Pens.YellowGreen, points[i].Point, points[i + 1].Point);
                    }

                    foreach (var (point, text) in points)
                    {
                        if (!string.IsNullOrEmpty(text))
                        {
                            g.DrawString(text, new Font("Arial", 10), Brushes.YellowGreen, point.X, point.Y - 15);
                        }
                    }
                }

                var harta = (PictureBox)this.Controls.Find("harta", true).FirstOrDefault();
                if (harta != null)
                {
                    harta.Image = background;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The terrain image file could not be found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while drawing the image: {ex.Message}");
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Harta = new Bitmap(harta.Width, harta.Height);
            g1 = Graphics.FromImage(Harta);
            deseneaza();
        }

        private void hartaButton_Click(object sender, EventArgs e)
        {
            string path = String.Concat(System.IO.Directory.GetCurrentDirectory() + "\\resurse\\harta.bmp");
            img = Image.FromFile(path);
            harta.Image = img;
            harta.Refresh();
        }

        void deseneaza()
        {
            g1.Clear(Color.White);
            g1.DrawImage(Harta, 0, 0, harta.Width, harta.Height);
            harta.Refresh();
        }
    }
}
