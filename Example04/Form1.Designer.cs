using System.Windows.Forms;

namespace Example04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // txtName
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.Name = "txtName";
            this.txtName.TabIndex = 0;
            this.txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // grpGender
            this.grpGender.Controls.Add(this.rdoNam);
            this.grpGender.Controls.Add(this.rdoNu);
            this.grpGender.Location = new System.Drawing.Point(20, 55);
            this.grpGender.Size = new System.Drawing.Size(260, 60);
            this.grpGender.Name = "grpGender";
            this.grpGender.Text = "Giới tính";
            this.grpGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // rdoNam
            this.rdoNam.Location = new System.Drawing.Point(20, 25);
            this.rdoNam.Size = new System.Drawing.Size(80, 20);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Text = "Nam";
            this.rdoNam.Checked = true;
            // rdoNu
            this.rdoNu.Location = new System.Drawing.Point(120, 25);
            this.rdoNu.Size = new System.Drawing.Size(80, 20);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Text = "Nữ";
            // chkGiamGia
            this.chkGiamGia.Location = new System.Drawing.Point(20, 125);
            this.chkGiamGia.Size = new System.Drawing.Size(80, 20);
            this.chkGiamGia.Name = "chkGiamGia";
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.Checked = true;
            this.chkGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // txtGiamGia
            this.txtGiamGia.Location = new System.Drawing.Point(110, 125);
            this.txtGiamGia.Size = new System.Drawing.Size(40, 22);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Text = "7";
            this.txtGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // txtResult
            this.txtResult.Location = new System.Drawing.Point(20, 160);
            this.txtResult.Size = new System.Drawing.Size(260, 60);
            this.txtResult.Name = "txtResult";
            this.txtResult.Multiline = true;
            this.txtResult.ReadOnly = true;
            this.txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // btnTinhTien
            this.btnTinhTien.Location = new System.Drawing.Point(50, 230);
            this.btnTinhTien.Size = new System.Drawing.Size(80, 30);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(170, 230);
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.chkGiamGia);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpGender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

