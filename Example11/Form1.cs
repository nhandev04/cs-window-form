using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int score = 0;
        private Random rand = new Random();
        private int eggSpeed = 5;
        private bool isEggBroken = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
            this.KeyDown += Form1_KeyDown;
            lblScore.Text = "Score: 0";
            picBasket.Image = Image.FromFile("images/basket.png");
            picEgg.Image = Image.FromFile("images/egg.png");
            picChicken.Image = Image.FromFile("images/chicken.png");
            picChicken.SizeMode = PictureBoxSizeMode.Zoom;
            picChicken.BackColor = Color.Transparent;
            ResetEgg();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isEggBroken)
            {
                picEgg.Top += eggSpeed;
                picChicken.Left = picEgg.Left - 10;
                // Trứng chạm giỏ
                if (picEgg.Bounds.IntersectsWith(picBasket.Bounds))
                {
                    score++;
                    lblScore.Text = $"Score: {score}";
                    ResetEgg();
                }
                // Trứng chạm sàn
                else if (picEgg.Top + picEgg.Height >= this.ClientSize.Height)
                {
                    try
                    {
                        picEgg.Image = Image.FromFile("images/egg_broken.png");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không tìm thấy ảnh trứng vỡ: {ex.Message}");
                    }
                    score = 0;
                    lblScore.Text = $"Score: {score}";
                    isEggBroken = true;
                    timer.Interval = 600; // Hiển thị trứng vỡ 0.6s
                }
            }
            else
            {
                // Sau khi trứng vỡ, reset lại trứng mới
                timer.Interval = 30;
                ResetEgg();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveStep = 20;
            if (e.KeyCode == Keys.Left)
            {
                picBasket.Left = Math.Max(0, picBasket.Left - moveStep);
            }
            else if (e.KeyCode == Keys.Right)
            {
                picBasket.Left = Math.Min(this.ClientSize.Width - picBasket.Width, picBasket.Left + moveStep);
            }
        }

        private void ResetEgg()
        {
            picEgg.Image = Image.FromFile("images/egg.png");
            picEgg.Left = rand.Next(0, this.ClientSize.Width - picEgg.Width);
            picEgg.Top = 40; // Đặt trứng cách mép trên 40px, giống vị trí con gà
            picChicken.Left = picEgg.Left - 10;
            isEggBroken = false;
        }
    }
}
