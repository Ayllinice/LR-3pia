using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_3ПИА
{
    public partial class Form1 : Form
    {
        public string player;
        public Form1()
        {
            InitializeComponent();
            player = "X";
            panel11.BackColor= Color.Cyan;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Panel_chengecolor(sender, e);
            
        }
        public void Panel_chengecolor(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.LightGray; // задаем новый цвет фона
            }
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.Transparent; // задаем новый цвет фона
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label4_MouseEnter(object sender, EventArgs e) //перекрашиваем лейбл при наведении мышкой
        {
            Label label = sender as Label;
            label.BackColor = Color.LightGray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.Transparent;
        }

        private object label4_MouseClick(object sender, MouseEventArgs e)
        {
            switch (player)
            {
                case "X":
                    panel11.BackColor= Color.Transparent;
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = "O";
                    panel10.BackColor= Color.Cyan;
                    if (CheckForWinner(player) == true)
                    {
                        MessageBox.Show("Player O Won");

                    }
                    break;


                case "O":
                    panel10.BackColor= Color.Transparent;
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = "X";
                    panel11.BackColor = Color.Cyan;
                    if (CheckForWinner(player) == true)
                    {
                        MessageBox.Show("Player X Won");
                        
                    }
                    break;

            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

            private void panel11_Paint(object sender, PaintEventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                for (int i = 4; i <= 13; i++)
                {
                    Control[] controls = this.Controls.Find("label" + i.ToString(), true);
                    if (controls.Length > 0)
                    {
                        Label label = (Label)controls[0];
                        label.Text = "";
                    }
                }
            }


            private void Form1_Paint(object sender, PaintEventArgs e)
            {

            }
            public bool CheckForWinner(string player)
            {
                string[,] gameBoard = new string[3, 3];
                gameBoard[0, 0] = label4.Text;
                gameBoard[0, 1] = label6.Text;
                gameBoard[0, 2] = label7.Text;
                gameBoard[1, 0] = label8.Text;
                gameBoard[1, 1] = label9.Text;
                gameBoard[1, 2] = label10.Text;
                gameBoard[2, 0] = label11.Text;
                gameBoard[2, 1] = label12.Text;
                gameBoard[2, 2] = label13.Text;
                // Проверяем по горизонтали
                for (int row = 0; row < 3; row++)
                {
                    if (gameBoard[row, 0] == player.ToString() && gameBoard[row, 1] == player.ToString() && gameBoard[row, 2] == player.ToString())
                    {
                        return true;
                    }
                }

                // Проверяем по вертикали
                for (int col = 0; col < 3; col++)
                {
                    if (gameBoard[0, col] == player.ToString() && gameBoard[1, col] == player.ToString() && gameBoard[2, col] == player.ToString())
                    {
                        return true;
                    }
                }

                // Проверяем по диагонали
                if (gameBoard[0, 0] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[2, 2] == player.ToString())
                {
                    return true;
                }
                if (gameBoard[0, 2] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[2, 0] == player.ToString())
                {
                    return true;
                }

                return false;
            }
    }
}

