using System.Windows.Forms;
using System.Drawing;

namespace Example09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picAvatar;
        private Button btLeft;
        private Button btRight;
        private Button btFile;
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
            this.picAvatar = new PictureBox();
            this.btLeft = new Button();
            this.btRight = new Button();
            this.btFile = new Button();
            this.SuspendLayout();
            // picAvatar
            this.picAvatar.Location = new Point(50, 30);
            this.picAvatar.Size = new Size(150, 180);
            this.picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAvatar.BorderStyle = BorderStyle.FixedSingle;
            this.picAvatar.Anchor = AnchorStyles.Top;
            // btLeft
            this.btLeft.Location = new Point(80, 230);
            this.btLeft.Size = new Size(50, 40);
            this.btLeft.Text = "<-";
            this.btLeft.Anchor = AnchorStyles.Top;
            // btRight
            this.btRight.Location = new Point(140, 230);
            this.btRight.Size = new Size(50, 40);
            this.btRight.Text = "->";
            this.btRight.Anchor = AnchorStyles.Top;
            // btFile
            this.btFile.Location = new Point(220, 230);
            this.btFile.Size = new Size(100, 40);
            this.btFile.Text = "File ...";
            this.btFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btFile);
            this.Name = "Form1";
            this.Text = "Simple Game";
            this.ResumeLayout(false);
        }
    }
}

