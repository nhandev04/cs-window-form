using System.Windows.Forms;

namespace Example08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvNhanVien;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtTuoi;
        private CheckBox chkNam;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblMa;
        private Label lblTen;
        private Label lblTuoi;
        private Label lblNam;
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
            this.dgvNhanVien = new DataGridView();
            this.txtMa = new TextBox();
            this.txtTen = new TextBox();
            this.txtTuoi = new TextBox();
            this.chkNam = new CheckBox();
            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblMa = new Label();
            this.lblTen = new Label();
            this.lblTuoi = new Label();
            this.lblNam = new Label();
            this.SuspendLayout();
            // dgvNhanVien
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 20);
            this.dgvNhanVien.Size = new System.Drawing.Size(800, 220);
            this.dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.Add("Ma", "Mã nhân viên");
            this.dgvNhanVien.Columns.Add("Ten", "Tên nhân viên");
            this.dgvNhanVien.Columns.Add("Tuoi", "Tuổi");
            var colNam = new DataGridViewCheckBoxColumn();
            colNam.HeaderText = "Giới tính (Nam)";
            colNam.Name = "Nam";
            this.dgvNhanVien.Columns.Add(colNam);
            // lblMa
            this.lblMa.Location = new System.Drawing.Point(40, 260);
            this.lblMa.Size = new System.Drawing.Size(40, 22);
            this.lblMa.Text = "Mã";
            // txtMa
            this.txtMa.Location = new System.Drawing.Point(90, 260);
            this.txtMa.Size = new System.Drawing.Size(200, 22);
            this.txtMa.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // lblTen
            this.lblTen.Location = new System.Drawing.Point(40, 295);
            this.lblTen.Size = new System.Drawing.Size(40, 22);
            this.lblTen.Text = "Tên";
            // txtTen
            this.txtTen.Location = new System.Drawing.Point(90, 295);
            this.txtTen.Size = new System.Drawing.Size(400, 22);
            this.txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // lblTuoi
            this.lblTuoi.Location = new System.Drawing.Point(40, 330);
            this.lblTuoi.Size = new System.Drawing.Size(40, 22);
            this.lblTuoi.Text = "Tuổi";
            // txtTuoi
            this.txtTuoi.Location = new System.Drawing.Point(90, 330);
            this.txtTuoi.Size = new System.Drawing.Size(100, 22);
            this.txtTuoi.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // chkNam
            this.chkNam.Location = new System.Drawing.Point(220, 330);
            this.chkNam.Size = new System.Drawing.Size(60, 22);
            this.chkNam.Text = "Nam";
            this.chkNam.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(400, 370);
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.Text = "Thêm";
            this.btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(510, 370);
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(620, 370);
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 430);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

