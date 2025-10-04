using System;
using System.Windows.Forms;

namespace Example05
{
    public partial class Form1 : Form
    {
        int studentCount = 0;
        public Form1()
        {
            InitializeComponent();
            btnThem.Click += BtnThem_Click;
            btnThoat.Click += (s, e) => this.Close();
            cboKhoa.Items.AddRange(new object[] {
                "Công nghệ thông tin",
                "Kế toán",
                "Cơ khí",
                "Điện",
                "Hóa"
            });
            cboKhoa.SelectedIndex = 0;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            studentCount++;
            string name = txtHoTen.Text.Trim();
            string gender = rdoNam.Checked ? "Nam" : "Nữ";
            string dob = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string khoa = cboKhoa.SelectedItem?.ToString() ?? "";
            lstTrangThai.Items.Add($"{studentCount}.{name}\n- Giới tính: {gender}\n- Ngày Sinh: {dob}\n- Khoa: {khoa}");
        }
    }
}
