using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {

        private List<Hoop> Snake = new List<Hoop>();
        private Hoop food = new Hoop();

        public Game()
        {
            InitializeComponent();

            Object.ResetSetting(false);

            if (Object.Speed <= 0)
                new Object();

            // Hız Ve Sayacın Aktif Edilmesi
            gameTimer.Interval = 1000 / Object.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            StartGame();
        }
        private void StartGame()
        {
            lblgg.Visible = false;

            Object.ResetSetting(true);

            // Yeni oyuncu nesnesi oluşturma
            Snake.Clear();
            Hoop head = new Hoop { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 2; i++)
            {
                Hoop Hoop = new Hoop
                {
                    X = Snake[Snake.Count - 1].X,
                    Y = Snake[Snake.Count - 1].Y
                };
                Snake.Add(Hoop);
            }

            lblLevel.Text = Object.Speed.ToString();
            lblScore.Text = Object.Score.ToString();
            GenerateFood();
        }
        //Yemek 
        private void GenerateFood()
        {
            int maxXPos = pbFrame.Size.Width / Object.Width;
            int maxYPos = pbFrame.Size.Height / Object.Height;

            Random random = new Random();
            food = new Hoop { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            // Oyun Bitti
            if (Object.GameOver)
            {
                //Enter Girildi 
                if (Keys.KeyPressed(System.Windows.Forms.Keys.Enter))
                {
                    StartGame();
                    menu.Hide();
                }
            }
            else if (Keys.KeyPressed(System.Windows.Forms.Keys.P))
            {
                if (Object.GamePause == true)
                    Object.GamePause = false;
                else
                    Object.GamePause = true;
            }
            else
            {
                if (Keys.KeyPressed(System.Windows.Forms.Keys.Right) && Object.direction != Direction.Left)
                    Object.direction = Direction.Right;
                else if (Keys.KeyPressed(System.Windows.Forms.Keys.Left) && Object.direction != Direction.Right)
                    Object.direction = Direction.Left;
                else if (Keys.KeyPressed(System.Windows.Forms.Keys.Up) && Object.direction != Direction.Down)
                    Object.direction = Direction.Up;
                else if (Keys.KeyPressed(System.Windows.Forms.Keys.Down) && Object.direction != Direction.Up)
                    Object.direction = Direction.Down;

                MovePlayer();
            }

            pbFrame.Invalidate();
        }

        private void pbFramePaint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Object.GameOver)
            {
                //Yılan Renk Belirlenmesi

                //Yılan Çizimi
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.DarkOrange;     //Kafa çizimi
                    else
                        snakeColour = Brushes.Yellow;    //Vucudun geri kalanı

                    // Yılan Çizimi
                    canvas.FillRectangle(snakeColour,
                        new Rectangle(Snake[i].X * Object.Width,
                                      Snake[i].Y * Object.Height,
                                      Object.Width, Object.Height));


                    //Draw Food - Yemek Çizimi
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Object.Width,
                             food.Y * Object.Height, Object.Width, Object.Height));
                }
            }
            else
            {
                string gameOver = "GG \nSkorunuz: " + Object.Score + "\nEnter ile tekrar oynayabilirisiniz";
                lblgg.Text = gameOver;
                lblgg.Visible = true;
                menu.Visible = true;
            }
        }

        private void MovePlayer()
        {
            if (Object.GamePause == true)
                return;

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Kafa taşıma veya hareket ettirme
                if (i == 0)
                {
                    switch (Object.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    // Maximum Pozisyon
                    int maxXPos = pbFrame.Size.Width / Object.Width;
                    int maxYPos = pbFrame.Size.Height / Object.Height;

                    // Sınıra Çarparsa
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    // Eğer Gövde İle Çarpışırsa
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    // Yemeği Ye
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    // Hareket
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            // Ekleme
            Hoop circle = new Hoop
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            // Skoru Güncelle
            Object.Score += Object.Speed;
            lblScore.Text = Object.Score.ToString();
            if (Snake.Count % 13 == 0)
            {
                Object.Speed++;
                gameTimer.Interval = 1000 / Object.Speed;
                lblLevel.Text = Object.Speed.ToString();
            }

            GenerateFood();
        }

        private void Die()
        {
            Object.GameOver = true;
        }
        
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Keys.ChangeState(e.KeyCode, true);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Keys.ChangeState(e.KeyCode, false);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void pbFrame_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            First goster = new First();
                goster.Show();
            this.Close();

        }

        private void lblS_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            First goster = new First();
            goster.Show();
            this.Close();
        }
    }
}