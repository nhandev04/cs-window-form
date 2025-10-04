using System.Drawing;
using System.Windows.Forms;

namespace Example11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox picBasket;
        private PictureBox picEgg;
        private Label lblScore;
        private PictureBox picChicken;

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
            this.picBasket = new System.Windows.Forms.PictureBox();
            this.picEgg = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picChicken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            this.SuspendLayout();
            // 
            // picBasket
            // 
            this.picBasket.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.picBasket.Image = System.Drawing.Image.FromFile("images/basket.png");
            this.picBasket.Location = new System.Drawing.Point(150, 320);
            this.picBasket.Name = "picBasket";
            this.picBasket.Size = new System.Drawing.Size(100, 60);
            this.picBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBasket.TabIndex = 0;
            this.picBasket.TabStop = false;
            // 
            // picEgg
            // 
            this.picEgg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.picEgg.Image = System.Drawing.Image.FromFile("images/egg.png");
            this.picEgg.Location = new System.Drawing.Point(180, 30); // Đặt trứng cách mép trên 30px
            this.picEgg.Name = "picEgg";
            this.picEgg.Size = new System.Drawing.Size(40, 50);
            this.picEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEgg.TabIndex = 1;
            this.picEgg.TabStop = false;
            // 
            // picChicken
            // 
            this.picChicken.Image = System.Drawing.Image.FromFile("images/chicken.png");
            this.picChicken.Location = new System.Drawing.Point(180, 40); // Đặt gà cách mép trên 40px
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(60, 60);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChicken.TabIndex = 3;
            this.picChicken.TabStop = false;
            this.picChicken.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(10, 10);
            this.lblScore.Size = new System.Drawing.Size(120, 40);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picChicken);
            this.Controls.Add(this.picEgg);
            this.Controls.Add(this.picBasket);
            this.Name = "Form1";
            this.Text = "Egg Catch Game";
            this.Padding = new Padding(0, 10, 0, 0); // Thêm padding top cho form
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

