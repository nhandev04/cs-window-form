using System.Windows.Forms;
using System.Drawing;

namespace Example12
{
    partial class FormResult
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtResult;
        private Button btnLamLai;
        private Button btnThoat;

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
            this.txtResult = new TextBox();
            this.btnLamLai = new Button();
            this.btnThoat = new Button();
            this.SuspendLayout();

            // txtResult
            this.txtResult.Location = new Point(20, 20);
            this.txtResult.Size = new Size(550, 350);
            this.txtResult.Multiline = true;
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = ScrollBars.Vertical;
            this.txtResult.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtResult.BackColor = Color.White;
            this.txtResult.BorderStyle = BorderStyle.FixedSingle;
            this.txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // btnLamLai
            this.btnLamLai.Text = "Lam lai";
            this.btnLamLai.Location = new Point(200, 390);
            this.btnLamLai.Size = new Size(100, 35);
            this.btnLamLai.Anchor = AnchorStyles.Bottom;
            this.btnLamLai.BackColor = Color.LightBlue;

            // btnThoat
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Location = new Point(320, 390);
            this.btnThoat.Size = new Size(100, 35);
            this.btnThoat.Anchor = AnchorStyles.Bottom;
            this.btnThoat.BackColor = Color.LightCoral;

            // FormResult
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(590, 440);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Name = "FormResult";
            this.Text = "Ket qua thi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}