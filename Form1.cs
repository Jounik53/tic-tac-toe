using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helloapp
{
    public partial class Chess : Form
    {
        int[] Logic = new int[9];
        public const string Zero = @"Resourses\O.bmp";
        public const string Cross = @"Resourses\X.bmp";
        public const string Onova = @"Resourses\Onova.bmp";
        public Chess()
        {
            InitializeComponent();
        }

        private void шашки_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Cross);
            pictureBox2.Image = Image.FromFile(Cross);
            pictureBox3.Image = Image.FromFile(Cross);
            pictureBox4.Image = Image.FromFile(Cross);
            pictureBox5.Image = Image.FromFile(Cross);
            pictureBox6.Image = Image.FromFile(Cross);
            pictureBox7.Image = Image.FromFile(Cross);
            pictureBox8.Image = Image.FromFile(Cross);
            pictureBox9.Image = Image.FromFile(Cross);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Zero);
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = Image.FromFile(Zero);            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Chess_Paint(object sender, PaintEventArgs e)
        {
            var image = Image.FromFile(Onova);
            e.Graphics.DrawImage(image,0,25);
        }
    }
}
