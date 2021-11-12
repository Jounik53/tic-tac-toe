using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Helloapp
{
    public partial class TicTackToe : Form
    {
        int[] Logic = new int[9];
        public const string Zero = @"Resourses\O.bmp";
        public const string Cross = @"Resourses\X.bmp";
        public const string Onova = @"Resourses\Onova.bmp";

        public bool FirstPlayer = true;
        public bool SecondPlayer = false;

        public int[] Board = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static readonly int[] BoardDefault = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void ChangePlayer()
        {
            if (FirstPlayer)
            {
                FirstPlayer = false;
                SecondPlayer = true;
            }
            else
            {
                FirstPlayer = true;
                SecondPlayer = false;
            }
        }

        private void LoadImage(object sender)
        {
            if (sender is PictureBox pictureBox)
            {
                var index = int.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 1, 1)) - 1;

                if (FirstPlayer)
                {
                    pictureBox.Image = Image.FromFile(Cross);
                    Board[index] = 1;
                }
                else
                {
                    pictureBox.Image = Image.FromFile(Zero);
                    Board[index] = 2;
                }
            }

            Win();
        }

        private void Win()
        {
            var win_first = new List<int[]>();
            win_first.Add(new[] { 1, 1, 1, 9, 9, 9, 9, 9, 9 });
            win_first.Add(new[] { 9, 9, 9, 1, 1, 1, 9, 9, 9 });
            win_first.Add(new[] { 9, 9, 9, 9, 9, 9, 1, 1, 1 });
            win_first.Add(new[] { 1, 9, 9, 1, 9, 9, 1, 9, 9 });
            win_first.Add(new[] { 9, 1, 9, 9, 1, 9, 9, 1, 9 });
            win_first.Add(new[] { 9, 9, 1, 9, 9, 1, 9, 9, 1 });
            win_first.Add(new[] { 1, 9, 9, 9, 1, 9, 9, 9, 1 });
            win_first.Add(new[] { 9, 9, 1, 9, 1, 9, 1, 9, 9 });

            var win_second = new List<int[]>();
            win_second.Add(new[] { 2, 2, 2, 9, 9, 9, 9, 9, 9 });
            win_second.Add(new[] { 9, 9, 9, 2, 2, 2, 9, 9, 9 });
            win_second.Add(new[] { 9, 9, 9, 9, 9, 9, 2, 2, 2 });
            win_second.Add(new[] { 2, 9, 9, 2, 9, 9, 2, 9, 9 });
            win_second.Add(new[] { 9, 2, 9, 9, 2, 9, 9, 2, 9 });
            win_second.Add(new[] { 9, 9, 2, 9, 9, 2, 9, 9, 2 });
            win_second.Add(new[] { 2, 9, 9, 9, 2, 9, 9, 9, 2 });
            win_second.Add(new[] { 9, 9, 2, 9, 2, 9, 2, 9, 9 });


            var boardFirstPlayer = InitializeBoard(Board, true);
            var boardSecondPlayer = InitializeBoard(Board, false);

            for (int i = 0; i < 8; i++)
            {
                if (boardFirstPlayer.SequenceEqual(win_first[i]))
                {
                    ClearBoard();
                    WinMessage("Winner First player!");
                }

                if (boardSecondPlayer.SequenceEqual(win_second[i]))
                {
                    ClearBoard();
                    WinMessage("Winner Second player!");
                }
            }
        }

        private void WinMessage(string message)
        {
            var control = this.Controls.Find("label1", true).FirstOrDefault();
            if (control != null)
            {
                if (control is Label label)
                {
                    label.Visible = true;
                    label.Text = message;
                }
            }
        }

        private void ClearBoard(bool newGame = false)
        {
            for (int i = 1; i <= 9; i++)
            {
                var control = this.Controls.Find($"PictureBox{i.ToString()}", true).FirstOrDefault();
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                    if (newGame)
                    {
                        pictureBox.Enabled = true;
                    }
                }
            }
        }

        private int[] InitializeBoard(int[] board, bool fistPlayer)
        {
            int[] localBoard = new int[9];
            if (fistPlayer)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i] != 1)
                    {
                        localBoard[i] = 9;
                    }
                    else
                    {
                        localBoard[i] = 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i] != 2)
                    {
                        localBoard[i] = 9;
                    }
                    else
                    {
                        localBoard[i] = 2;
                    }
                }
            }

            return localBoard;
        }

        public void Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                LoadImage(sender);
                pictureBox.Enabled = false;
                ChangePlayer();
            }
        }

        public TicTackToe()
        {
            InitializeComponent();
        }

        private void шашки_Load(object sender, EventArgs e)
        {
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Board = BoardDefault;
            ClearBoard(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Chess_Paint(object sender, PaintEventArgs e)
        {
            var image = Image.FromFile(Onova);
            e.Graphics.DrawImage(image, 9, 25);
        }
    }
}