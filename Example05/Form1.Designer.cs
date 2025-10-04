using System.Windows.Forms;

namespace Example05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ListBox lstTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTrangThai;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lstTrangThai = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(20, 20);
            this.lblHoTen.Size = new System.Drawing.Size(80, 22);
            this.lblHoTen.Text = "Họ và tên";
            this.lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 20);
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);
            this.txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 55);
            this.lblNgaySinh.Size = new System.Drawing.Size(80, 22);
            this.lblNgaySinh.Text = "Ngày Sinh";
            this.lblNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 55);
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 22);
            this.dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoNam);
            this.grpGender.Controls.Add(this.rdoNu);
            this.grpGender.Location = new System.Drawing.Point(110, 90);
            this.grpGender.Size = new System.Drawing.Size(250, 50);
            this.grpGender.Text = "Giới tính";
            this.grpGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // rdoNam
            // 
            this.rdoNam.Location = new System.Drawing.Point(20, 20);
            this.rdoNam.Size = new System.Drawing.Size(60, 20);
            this.rdoNam.Text = "Nam";
            this.rdoNam.Checked = true;
            this.rdoNam.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // rdoNu
            // 
            this.rdoNu.Location = new System.Drawing.Point(120, 20);
            this.rdoNu.Size = new System.Drawing.Size(60, 20);
            this.rdoNu.Text = "Nữ";
            this.rdoNu.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(20, 150);
            this.lblKhoa.Size = new System.Drawing.Size(80, 22);
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(110, 150);
            this.cboKhoa.Size = new System.Drawing.Size(250, 24);
            this.cboKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(20, 185);
            this.lblTrangThai.Size = new System.Drawing.Size(80, 22);
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // lstTrangThai
            // 
            this.lstTrangThai.Location = new System.Drawing.Point(110, 185);
            this.lstTrangThai.Size = new System.Drawing.Size(250, 120);
            this.lstTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(110, 320);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(280, 320);
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lstTrangThai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.grpGender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

