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
        int laser_height;

        public road()
        {
            InitializeComponent();
            laser_height = laser1.Height;
            gameover_lbl.Visible = false;
            score = 0;
            laser1.Size = new Size(50, laser_height);
            laser2.Size = new Size(50, laser_height);
            laser3.Size = new Size(50, laser_height);
            laser4.Size = new Size(50, laser_height);
            laser5.Size = new Size(50, laser_height);
        }

        public void laserfire(int speed)
        {
            if (laser1.Visible == true)
            {
                if (laser1.Top <= -90)
                {
                    laser1.Visible = false;
                }
                else
                {
                    laser1.Top -= speed + 5;
                }
            }
            else if (laser2.Visible == true)
            {
                if (laser2.Top <= -90)
                {
                    laser2.Visible = false;
                    laser2.Location = new Point(-50, 0);
                }
                else
                {
                    laser2.Top -= speed + 5;
                }
            }
            else if (laser3.Visible == true)
            {
                if (laser3.Top <= -90)
                {
                    laser3.Visible = false;
                    laser3.Location = new Point(-50, 0);
                }
                else
                {
                    laser3.Top -= speed + 5;
                }
            }
            else if (laser4.Visible == true)
            {
                if (laser4.Top <= -90)
                {
                    laser4.Visible = false;
                    laser4.Location = new Point(-50, 0);
                }
                else
                {
                    laser4.Top -= speed + 5;
                }
            }
            else if (laser5.Visible == true)
            {
                if (laser5.Bottom < -10)
                {
                    laser5.Visible = false;
                    laser5.Location = new Point(-50, 0);
                }
                else
                {
                    laser5.Top -= speed + 5;
                }
            }
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
            laserfire(speed);
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

            if (laser1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy1.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy2.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy3.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }

            if (laser2.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy1.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser2.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy2.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser2.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy3.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }

            if (laser3.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy1.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser3.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy2.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser3.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy3.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }

            if (laser4.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy1.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser4.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy2.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser4.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy3.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }

            if (laser5.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy1.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser5.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy2.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
            }
            if (laser5.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int x = random.Next(30, 305);
                int y = random.Next(-200, -150);
                enemy3.Location = new Point(x, y);
                score++;
                score_lbl.Text = "Score: " + score;
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
                if (speed >= 5)
                {
                    score += 2;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin1.Location = new Point(x, y);
                    if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value < num_shots.Maximum - 2)
                    {
                        num_shots.Value += 2;
                    }
                    else if (num_shots.Value > num_shots.Maximum - 3)
                    {
                        num_shots.Value++;
                    }
                }
                else if (speed >= 10)
                {
                    score += 3;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin2.Location = new Point(x, y);
                    if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value <= num_shots.Maximum - 3)
                    {
                        num_shots.Value += 3;
                    }
                    else if (num_shots.Value > num_shots.Maximum - 4)
                    {
                        num_shots.Value++;
                    }
                }
                else if (speed < 5)
                {
                    num_shots.Value++;
                    score++;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin1.Location = new Point(x, y);
                }
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
                if (speed >= 5)
                {
                    score += 2;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin2.Location = new Point(x, y);
                    if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value <= num_shots.Maximum - 2)
                    {
                        num_shots.Value += 2;
                    }
                    else if (num_shots.Value > num_shots.Maximum - 3)
                    {
                        num_shots.Value++;
                    }
                }
                else if (speed >= 10)
                {
                    score += 3;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin2.Location = new Point(x, y);
                    if (num_shots.Value > num_shots.Maximum - 4)
                    {
                        num_shots.Value++;
                    }
                    else if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value <= num_shots.Maximum - 3)
                    {
                        num_shots.Value += 3;
                    }
                }
                else if (speed < 5)
                {
                    num_shots.Value++;
                    score++;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin2.Location = new Point(x, y);
                }
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
                if (speed >= 5)
                {
                    score += 2;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin3.Location = new Point(x, y);
                    if (num_shots.Value > num_shots.Maximum - 3)
                    {
                        num_shots.Value++;
                    }
                    else if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value < num_shots.Maximum - 2)
                    {
                        num_shots.Value += 2;
                    }
                }
                else if (speed >= 10)
                {
                    score += 3;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin2.Location = new Point(x, y);
                    if (num_shots.Value > num_shots.Maximum - 4)
                    {
                        num_shots.Value++;
                    }
                    else if (num_shots.Value == num_shots.Maximum)
                    {
                        num_shots.Value = 5;
                    }
                    else if (num_shots.Value <= num_shots.Maximum - 3)
                    {
                        num_shots.Value += 3;
                    }
                }
                else if (speed < 5)
                {
                    num_shots.Value++;
                    score++;
                    score_lbl.Text = "Score: " + score;
                    int x = random.Next(30, 305);
                    int y = random.Next(-150, -40);
                    coin3.Location = new Point(x, y);
                }
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
                    speed_lbl.Text = "Speed: " + speed;
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (speed > 0)
                {
                    speed--;
                    speed_lbl.Text = "Speed: " + speed;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                if (speed != 0)
                {
                    if (num_shots.Value > 0)
                    {
                        if (laser1.Visible == false)
                        {
                            num_shots.Value--;
                            int x = playerCar.Left + 7;
                            laser1.Location = new Point(x, 525);
                            laser1.Visible = true;
                        }
                        else if (laser2.Visible == false)
                        {
                            num_shots.Value--;
                            int x = playerCar.Left + 7;
                            laser2.Location = new Point(x, 525);
                            laser2.Visible = true;
                        }
                        else if (laser3.Visible == false)
                        {
                            num_shots.Value--;
                            int x = playerCar.Left + 7;
                            laser3.Location = new Point(x, 525);
                            laser3.Visible = true;
                        }
                        else if (laser4.Visible == false)
                        {
                            num_shots.Value--;
                            int x = playerCar.Left + 7;
                            laser4.Location = new Point(x, 525);
                            laser4.Visible = true;
                        }
                        else if (laser5.Visible == false)
                        {
                            num_shots.Value--;
                            int x = playerCar.Left + 7;
                            laser5.Location = new Point(x, 525);
                            laser5.Visible = true;
                        }
                    }
                    else if (num_shots.Value <= 0)
                    {
                        score--;
                        score_lbl.Text = "Score: " + score;
                    }
                }
            }
        }
    }
}
