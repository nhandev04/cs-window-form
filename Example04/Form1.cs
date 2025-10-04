using System;
using System.Windows.Forms;

namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnTinhTien.Click += BtnTinhTien_Click;
            btnThoat.Click += (s, e) => this.Close();
        }

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = rdoNam.Checked ? "Ông" : "Bà";
            string discount = chkGiamGia.Checked ? txtGiamGia.Text.Trim() : "0";
            txtResult.Text = $"{gender} {name} được giảm {discount}%";
        }
    }
}
