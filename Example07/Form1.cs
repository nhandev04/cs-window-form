using System;
using System.Windows.Forms;
using System.Drawing;

namespace Example07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnChonAnh.Click += BtnChonAnh_Click;
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh nhân viên";
                dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(dlg.FileName);
                }
            }
        }
    }
}
