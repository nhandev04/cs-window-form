using System;
using System.Windows.Forms;
using System.Drawing;

namespace Example09
{
    public partial class Form1 : Form
    {
        private int picX = 50;
        private readonly int picY = 30;
        private readonly int moveStep = 50;
        public Form1()
        {
            InitializeComponent();
            btLeft.Click += BtLeft_Click;
            btRight.Click += BtRight_Click;
            btFile.Click += BtFile_Click;
        }

        private void BtLeft_Click(object sender, EventArgs e)
        {
            picX = Math.Max(0, picX - moveStep);
            picAvatar.Location = new Point(picX, picY);
        }

        private void BtRight_Click(object sender, EventArgs e)
        {
            picX = Math.Min(this.ClientSize.Width - picAvatar.Width - 20, picX + moveStep);
            picAvatar.Location = new Point(picX, picY);
        }

        private void BtFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh";
                dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(dlg.FileName);
                }
            }
        }
    }
}
