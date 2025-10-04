using System;
using System.Windows.Forms;

namespace Example08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += (s, e) => this.Close();
            dgvNhanVien.SelectionChanged += DgvNhanVien_SelectionChanged;
            // Khởi tạo dữ liệu mẫu
            dgvNhanVien.Rows.Add("53418", "Trần Tiến", 20, true);
            dgvNhanVien.Rows.Add("53416", "Nguyễn Cường", 25, false);
            dgvNhanVien.Rows.Add("53417", "Nguyễn Hào", 23, true);
            if (dgvNhanVien.Rows.Count > 0)
                dgvNhanVien.Rows[0].Selected = true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Add(txtMa.Text, txtTen.Text, txtTuoi.Text, chkNam.Checked);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
            {
                if (!row.IsNewRow)
                    dgvNhanVien.Rows.Remove(row);
            }
        }

        private void DgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                var row = dgvNhanVien.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value?.ToString() ?? "";
                txtTen.Text = row.Cells[1].Value?.ToString() ?? "";
                txtTuoi.Text = row.Cells[2].Value?.ToString() ?? "";
                chkNam.Checked = row.Cells[3].Value != null && (bool)row.Cells[3].Value;
            }
        }
    }
}
