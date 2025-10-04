// -*- coding: utf-8 -*-
using System.Windows.Forms;
using System.Drawing;

namespace Example12
{
    partial class FormQuestion
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpInfo;
        private Label lblMa, lblTen, lblNgaySinh;
        private Label lblTime;
        private GroupBox grpQuestion;
        private Label lblQuestionNumber;
        private Label lblQuestion;
        private RadioButton rdo1, rdo2, rdo3, rdo4;
        private Button btnPrev, btnNext, btnFinish;

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
            this.grpInfo = new GroupBox();
            this.lblMa = new Label();
            this.lblTen = new Label();
            this.lblNgaySinh = new Label();
            this.lblTime = new Label();
            this.grpQuestion = new GroupBox();
            this.lblQuestionNumber = new Label();
            this.lblQuestion = new Label();
            this.rdo1 = new RadioButton();
            this.rdo2 = new RadioButton();
            this.rdo3 = new RadioButton();
            this.rdo4 = new RadioButton();
            this.btnPrev = new Button();
            this.btnNext = new Button();
            this.btnFinish = new Button();
            this.grpInfo.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();

            // grpInfo
            this.grpInfo.Text = "Thong tin thi sinh";
            this.grpInfo.Location = new Point(20, 20);
            this.grpInfo.Size = new Size(600, 80);
            this.grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lblMa.Location = new Point(20, 25); 
            this.lblMa.Size = new Size(80, 20); 
            this.lblMa.Text = "Ma: 1";

            this.lblTen.Location = new Point(120, 25); 
            this.lblTen.Size = new Size(200, 20); 
            this.lblTen.Text = "Ten: Nguyen Anh Tu";

            this.lblNgaySinh.Location = new Point(350, 25); 
            this.lblNgaySinh.Size = new Size(150, 20); 
            this.lblNgaySinh.Text = "Ngay sinh: 10/10/1994";

            this.lblTime.Location = new Point(20, 50); 
            this.lblTime.Size = new Size(200, 20); 
            this.lblTime.Text = "Thoi gian con lai: 10:00";
            this.lblTime.ForeColor = Color.Red; 
            this.lblTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

            // grpQuestion
            this.grpQuestion.Text = "Cau hoi";
            this.grpQuestion.Location = new Point(20, 120);
            this.grpQuestion.Size = new Size(600, 300);
            this.grpQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            this.lblQuestionNumber.Location = new Point(20, 25); 
            this.lblQuestionNumber.Size = new Size(100, 25);
            this.lblQuestionNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold); 
            this.lblQuestionNumber.Text = "Cau 1";

            this.lblQuestion.Location = new Point(20, 60); 
            this.lblQuestion.Size = new Size(560, 60);
            this.lblQuestion.Font = new Font("Microsoft Sans Serif", 10F); 
            this.lblQuestion.Text = "Mot cong mot bang bao nhieu?";
            this.lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.rdo1.Location = new Point(40, 130); 
            this.rdo1.Size = new Size(520, 25); 
            this.rdo1.Text = "Hai";
            this.rdo1.Font = new Font("Microsoft Sans Serif", 9F); 
            this.rdo1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.rdo2.Location = new Point(40, 160); 
            this.rdo2.Size = new Size(520, 25); 
            this.rdo2.Text = "Bon";
            this.rdo2.Font = new Font("Microsoft Sans Serif", 9F); 
            this.rdo2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.rdo3.Location = new Point(40, 190); 
            this.rdo3.Size = new Size(520, 25); 
            this.rdo3.Text = "Nam";
            this.rdo3.Font = new Font("Microsoft Sans Serif", 9F); 
            this.rdo3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.rdo4.Location = new Point(40, 220); 
            this.rdo4.Size = new Size(520, 25); 
            this.rdo4.Text = "Ba";
            this.rdo4.Font = new Font("Microsoft Sans Serif", 9F); 
            this.rdo4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Buttons
            this.btnPrev.Text = "< Truoc"; 
            this.btnPrev.Location = new Point(180, 440); 
            this.btnPrev.Size = new Size(80, 35);
            this.btnPrev.Anchor = AnchorStyles.Bottom;

            this.btnNext.Text = "Tiep >"; 
            this.btnNext.Location = new Point(270, 440); 
            this.btnNext.Size = new Size(80, 35);
            this.btnNext.Anchor = AnchorStyles.Bottom;

            this.btnFinish.Text = "Nop bai"; 
            this.btnFinish.Location = new Point(360, 440); 
            this.btnFinish.Size = new Size(80, 35);
            this.btnFinish.Anchor = AnchorStyles.Bottom; 
            this.btnFinish.BackColor = Color.Orange;

            // Add controls
            this.grpInfo.Controls.AddRange(new Control[] { lblMa, lblTen, lblNgaySinh, lblTime });
            this.grpQuestion.Controls.AddRange(new Control[] { lblQuestionNumber, lblQuestion, rdo1, rdo2, rdo3, rdo4 });

            // FormQuestion
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 490);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinish);
            this.Name = "FormQuestion";
            this.Text = "Lam bai thi";
            this.grpInfo.ResumeLayout(false);
            this.grpQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}