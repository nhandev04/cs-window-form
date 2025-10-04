using System.Windows.Forms;
using System.Drawing;

namespace Example07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private Label lblMaNV;
        private Label lblTenNV;
        private Label lblAnh;
        private PictureBox picAnh;
        private Button btnChonAnh;
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
            this.txtMaNV = new TextBox();
            this.txtTenNV = new TextBox();
            this.lblMaNV = new Label();
            this.lblTenNV = new Label();
            this.lblAnh = new Label();
            this.picAnh = new PictureBox();
            this.btnChonAnh = new Button();
            this.SuspendLayout();
            // lblMaNV
            this.lblMaNV.Location = new System.Drawing.Point(20, 20);
            this.lblMaNV.Size = new System.Drawing.Size(90, 22);
            this.lblMaNV.Text = "Mã nhân viên";
            // txtMaNV
            this.txtMaNV.Location = new System.Drawing.Point(120, 20);
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.Text = "03152482001";
            this.txtMaNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // lblTenNV
            this.lblTenNV.Location = new System.Drawing.Point(20, 55);
            this.lblTenNV.Size = new System.Drawing.Size(90, 22);
            this.lblTenNV.Text = "Tên nhân viên";
            // txtTenNV
            this.txtTenNV.Location = new System.Drawing.Point(120, 55);
            this.txtTenNV.Size = new System.Drawing.Size(200, 22);
            this.txtTenNV.Text = "Nguyễn Văn Hùng";
            this.txtTenNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // lblAnh
            this.lblAnh.Location = new System.Drawing.Point(20, 90);
            this.lblAnh.Size = new System.Drawing.Size(90, 22);
            this.lblAnh.Text = "Anh 3 x 4";
            // picAnh
            this.picAnh.Location = new System.Drawing.Point(120, 90);
            this.picAnh.Size = new System.Drawing.Size(120, 150);
            this.picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAnh.BorderStyle = BorderStyle.FixedSingle;
            this.picAnh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // btnChonAnh
            this.btnChonAnh.Location = new System.Drawing.Point(250, 130);
            this.btnChonAnh.Size = new System.Drawing.Size(100, 30);
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

