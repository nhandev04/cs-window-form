using System.Windows.Forms;
using System.Drawing;

namespace Example10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblTime;
        private Button btnStart;
        private Button btnStop;
        private Button btnClear;

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
            this.lblTime = new Label();
            this.btnStart = new Button();
            this.btnStop = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();
            // lblTime
            this.lblTime.Location = new Point(60, 30);
            this.lblTime.Size = new Size(220, 60);
            this.lblTime.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // btnStart
            this.btnStart.Location = new Point(40, 110);
            this.btnStart.Size = new Size(80, 35);
            this.btnStart.Text = "Start";
            this.btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // btnStop
            this.btnStop.Location = new Point(140, 110);
            this.btnStop.Size = new Size(80, 35);
            this.btnStop.Text = "Stop";
            this.btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // btnClear
            this.btnClear.Location = new Point(240, 110);
            this.btnClear.Size = new Size(80, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 170);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Timer Article";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

