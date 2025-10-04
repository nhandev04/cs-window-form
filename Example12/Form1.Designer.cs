using System.Windows.Forms;
using System.Drawing;

namespace Example12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpThongTin;
        private TextBox txtMa;
        private TextBox txtTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtNoiSinh;
        private ComboBox cboGioiTinh;
        private TextBox txtDiaChi;
        private GroupBox grpKyThi;
        private ComboBox cboDanhSach;
        private TextBox txtSoCauHoi;
        private TextBox txtThoiGian;
        private Button btnBatDau;
        private Label lblMa, lblTen, lblNgaySinh, lblNoiSinh, lblGioiTinh, lblDiaChi;
        private Label lblDanhSach, lblSoCauHoi, lblThoiGian;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new GroupBox();
            this.txtMa = new TextBox();
            this.txtTen = new TextBox();
            this.dtpNgaySinh = new DateTimePicker();
            this.txtNoiSinh = new TextBox();
            this.cboGioiTinh = new ComboBox();
            this.txtDiaChi = new TextBox();
            this.grpKyThi = new GroupBox();
            this.cboDanhSach = new ComboBox();
            this.txtSoCauHoi = new TextBox();
            this.txtThoiGian = new TextBox();
            this.btnBatDau = new Button();
            this.lblMa = new Label();
            this.lblTen = new Label();
            this.lblNgaySinh = new Label();
            this.lblNoiSinh = new Label();
            this.lblGioiTinh = new Label();
            this.lblDiaChi = new Label();
            this.lblDanhSach = new Label();
            this.lblSoCauHoi = new Label();
            this.lblThoiGian = new Label();
            this.grpThongTin.SuspendLayout();
            this.grpKyThi.SuspendLayout();
            this.SuspendLayout();

            // grpThongTin
            this.grpThongTin.Text = "Thong tin thi sinh";
            this.grpThongTin.Location = new Point(20, 20);
            this.grpThongTin.Size = new Size(400, 250);
            this.grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Labels va controls trong grpThongTin
            this.lblMa.Text = "Ma"; this.lblMa.Location = new Point(20, 30); this.lblMa.Size = new Size(80, 20);
            this.txtMa.Location = new Point(100, 30); this.txtMa.Size = new Size(120, 22); this.txtMa.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.lblTen.Text = "Ten"; this.lblTen.Location = new Point(20, 60); this.lblTen.Size = new Size(80, 20);
            this.txtTen.Location = new Point(100, 60); this.txtTen.Size = new Size(280, 22); this.txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lblNgaySinh.Text = "Ngay sinh"; this.lblNgaySinh.Location = new Point(20, 90); this.lblNgaySinh.Size = new Size(80, 20);
            this.dtpNgaySinh.Location = new Point(100, 90); this.dtpNgaySinh.Size = new Size(150, 22); this.dtpNgaySinh.Format = DateTimePickerFormat.Custom; this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            this.lblNoiSinh.Text = "Noi sinh"; this.lblNoiSinh.Location = new Point(20, 120); this.lblNoiSinh.Size = new Size(80, 20);
            this.txtNoiSinh.Location = new Point(100, 120); this.txtNoiSinh.Size = new Size(280, 22); this.txtNoiSinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lblGioiTinh.Text = "Gioi tinh"; this.lblGioiTinh.Location = new Point(20, 150); this.lblGioiTinh.Size = new Size(80, 20);
            this.cboGioiTinh.Location = new Point(100, 150); this.cboGioiTinh.Size = new Size(120, 24);
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nu" }); this.cboGioiTinh.SelectedIndex = 0;

            this.lblDiaChi.Text = "Dia chi"; this.lblDiaChi.Location = new Point(20, 180); this.lblDiaChi.Size = new Size(80, 20);
            this.txtDiaChi.Location = new Point(100, 180); this.txtDiaChi.Size = new Size(280, 22); this.txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // grpKyThi
            this.grpKyThi.Text = "Thong tin ky thi";
            this.grpKyThi.Location = new Point(20, 290);
            this.grpKyThi.Size = new Size(400, 100);
            this.grpKyThi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lblDanhSach.Text = "Danh sach ky thi"; this.lblDanhSach.Location = new Point(20, 30); this.lblDanhSach.Size = new Size(100, 20);
            this.cboDanhSach.Location = new Point(130, 30); this.cboDanhSach.Size = new Size(200, 24); this.cboDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cboDanhSach.Items.Add("Chung chi lop 1"); this.cboDanhSach.SelectedIndex = 0;

            this.lblSoCauHoi.Text = "So cau hoi:"; this.lblSoCauHoi.Location = new Point(20, 60); this.lblSoCauHoi.Size = new Size(80, 20);
            this.txtSoCauHoi.Location = new Point(100, 60); this.txtSoCauHoi.Size = new Size(60, 22); this.txtSoCauHoi.Text = "20"; this.txtSoCauHoi.ReadOnly = true;

            this.lblThoiGian.Text = "Thoi gian:"; this.lblThoiGian.Location = new Point(200, 60); this.lblThoiGian.Size = new Size(80, 20);
            this.txtThoiGian.Location = new Point(280, 60); this.txtThoiGian.Size = new Size(60, 22); this.txtThoiGian.Text = "600"; this.txtThoiGian.ReadOnly = true;

            // btnBatDau
            this.btnBatDau.Text = "Bat dau";
            this.btnBatDau.Location = new Point(170, 410);
            this.btnBatDau.Size = new Size(100, 35);
            this.btnBatDau.Anchor = AnchorStyles.Bottom;

            // Them controls vao groups
            this.grpThongTin.Controls.AddRange(new Control[] { lblMa, txtMa, lblTen, txtTen, lblNgaySinh, dtpNgaySinh, lblNoiSinh, txtNoiSinh, lblGioiTinh, cboGioiTinh, lblDiaChi, txtDiaChi });
            this.grpKyThi.Controls.AddRange(new Control[] { lblDanhSach, cboDanhSach, lblSoCauHoi, txtSoCauHoi, lblThoiGian, txtThoiGian });

            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(440, 460);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpKyThi);
            this.Controls.Add(this.btnBatDau);
            this.Name = "Form1";
            this.Text = "He thong thi trac nghiem";
            this.grpThongTin.ResumeLayout(false);
            this.grpKyThi.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

