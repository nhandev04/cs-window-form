using System;
using System.Windows.Forms;

namespace Example12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnBatDau.Click += BtnBatDau_Click;
        }

        private void BtnBatDau_Click(object sender, EventArgs e)
        {
            // Kiem tra thong tin da nhap day du
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(txtNoiSinh.Text) || string.IsNullOrEmpty(txtDiaChi.Text) ||
                cboGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao");
                return;
            }

            // Chuyen sang form lam bai thi
            FormQuestion frmQuestion = new FormQuestion();
            frmQuestion.StudentInfo = new StudentInfo
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                NoiSinh = txtNoiSinh.Text,
                GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                DiaChi = txtDiaChi.Text
            };
            frmQuestion.Show();
            this.Hide();
        }
    }

    public class StudentInfo
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
    }
}
