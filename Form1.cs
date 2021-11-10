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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox1");
            pictureBox1.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox2");
            pictureBox2.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox3");
            pictureBox3.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox4");
            pictureBox4.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox5");
            pictureBox5.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox6");
            pictureBox6.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox7");
            pictureBox7.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox8");
            pictureBox8.Enabled = false;
            ChangePlayer();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LoadImage("pictureBox9");
            pictureBox9.Enabled = false;
            ChangePlayer();
        }
    }
}