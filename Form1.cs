using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Helloapp
{
    public partial class Chess : Form
    {
        int[] Logic = new int[9];
        public const string Zero = @"Resourses\O.bmp";
        public const string Cross = @"Resourses\X.bmp";
        public const string Onova = @"Resourses\Onova.bmp";

        public bool firstPlayer = true;
        public bool secondPlayer = false;

        private void ChangePlayer()
        {
            if (firstPlayer)
            {
                firstPlayer = false;
                secondPlayer = true;
            }
            else
            {
                firstPlayer = true;
                secondPlayer = false;
            }
        }

        private void LoadImage(string componentName)
        {
            var control = this.Controls.Find(componentName, true).FirstOrDefault();

            if (control != null)
            {
                if (control is PictureBox pictureBox)
                {
                    if (firstPlayer)
                    {
                        pictureBox.Image = Image.FromFile(Cross);
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(Zero);
                    }
                }
            }
        }

        public void Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                LoadImage(pictureBox.Name);
                pictureBox.Enabled = false;
                ChangePlayer();
            }
        }

        public Chess()
        {
            InitializeComponent();
        }

        private void шашки_Load(object sender, EventArgs e)
        {
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Chess_Paint(object sender, PaintEventArgs e)
        {
            var image = Image.FromFile(Onova);
            e.Graphics.DrawImage(image, 0, 25);
        }
    }
}