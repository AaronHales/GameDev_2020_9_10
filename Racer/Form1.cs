using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racer
{
    public partial class road : Form
    {

        int speed = 0;
        Random random = new Random();
        int score = 0;

        public road()
        {
            InitializeComponent();
            gameover_lbl.Visible = false;
            score = 0;
        }

        public void gameover()
        {
            if (playerCar.Bounds.IntersectsWith(enemy1.Bounds))
            {
                gameloop.Enabled = false;
                speed = 0;
                gameover_lbl.Visible = true;
            }
            if (playerCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                gameloop.Enabled = false;
                speed = 0;
                gameover_lbl.Visible = true;
            }
            if (playerCar.Bounds.IntersectsWith(enemy3.Bounds))
            {
                gameloop.Enabled = false;
                speed = 0;
                gameover_lbl.Visible = true;
            }
        }

        private void gameloop_Tick(object sender, EventArgs e)
        {
            moveLine(speed);
            enemy(speed);
            collectable(speed);
            gameover();
        }

        public void enemy(int speed)
        {
            if (speed != 0)
            {
                if (enemy1.Top > 800)
                {
                    int x = random.Next(30, 305);
                    int y = random.Next(-160, -100);
                    enemy1.Location = new Point(x, y);
                }
                else
                {
                    enemy1.Top += speed + 2;
                }
            }

            if (speed != 0)
            {
                if (enemy2.Top > 800)
                {
                    int x = random.Next(30, 305);
                    int y = random.Next(-160, -100);
                    enemy2.Location = new Point(x, y);
                }
                else
                {
                    enemy2.Top += speed + 2;
                }
            }

            if (speed != 0)
            {
                if (enemy3.Top > 800)
                {
                    int x = random.Next(30, 305);
                    int y = random.Next(-160, -100);
                    enemy3.Location = new Point(x, y);
                }
                else
                {
                    enemy3.Top += speed + 2;
                }
            }
        }
        public void collectable(int speed)
        {
            if (coin1.Top > 800)
            {
                int x = random.Next(30, 305);
                int y = random.Next(-150, -40);
                coin1.Location = new Point(x, y);
            }
            else
            {
                coin1.Top += speed;
            }
            if (playerCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                score++;
                score_lbl.Text = "Score: " + score;
                int x = random.Next(30, 305);
                int y = random.Next(-150, -40);
                coin1.Location = new Point(x, y);
            }

            if (coin2.Top > 800)
            {
                int x = random.Next(30, 305);
                int y = random.Next(-150, 0);
                coin2.Location = new Point(x, y);
            }
            else
            {
                coin2.Top += speed;
            }
            if (playerCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                score++;
                score_lbl.Text = "Score: " + score;
                int x = random.Next(30, 305);
                int y = random.Next(-150, -40);
                coin2.Location = new Point(x, y);
            }

            if (coin3.Top > 800)
            {
                int x = random.Next(30, 305);
                int y = random.Next(-150, -40);
                coin3.Location = new Point(x, y);
            }
            else
            {
                coin3.Top += speed;
            }
            if (playerCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                score++;
                score_lbl.Text = "Score: " + score;
                int x = random.Next(30, 305);
                int y = random.Next(-150, -40);
                coin3.Location = new Point(x, y);
            }

        }

        public void moveLine(int speed)
        {
            if (pictureBox1.Top >= 800)
            {
                pictureBox1.Top = -70;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 800)
            {
                pictureBox2.Top = -70;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 800)
            {
                pictureBox3.Top = -70;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 800)
            {
                pictureBox4.Top = -70;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 800)
            {
                pictureBox5.Top = -70;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            if (pictureBox6.Top >= 800)
            {
                pictureBox6.Top = -70;
            }
            else
            {
                pictureBox6.Top += speed;
            }
            if (pictureBox7.Top >= 800)
            {
                pictureBox7.Top = -70;
            }
            else
            {
                pictureBox7.Top += speed;
            }
            if (pictureBox8.Top >= 800)
            {
                pictureBox8.Top = -70;
            }
            else
            {
                pictureBox8.Top += speed;
            }
        }

        private void road_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (speed != 0)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    if (playerCar.Left > 0)
                    {
                        playerCar.Left += -10;
                    }
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    if (playerCar.Right <= 380)
                    {
                        playerCar.Left += 10;
                    }
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (speed < 20)
                {
                    speed++;
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (speed > 0)
                {
                    speed--;
                }
            }
        }
    }
}
