using System.Windows.Forms;

namespace Example02
{
    partial class SimpleCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button[] buttons;
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
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new TextBox();
            this.buttons = new Button[16];
            this.SuspendLayout();
            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 39);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            // Button labels
            string[] labels = {
                "7", "8", "9", "/",
                "4", "5", "6", "*",
                "1", "2", "3", "-",
                "0", ".", "=", "+"
            };
            // Button positions
            for (int i = 0; i < labels.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = labels[i];
                buttons[i].Font = new System.Drawing.Font("Segoe UI", 12F);
                buttons[i].Size = new System.Drawing.Size(60, 40);
                int row = i / 4, col = i % 4;
                buttons[i].Location = new System.Drawing.Point(12 + col * 65, 60 + row * 45);
                buttons[i].Name = "btn" + labels[i];
                buttons[i].TabIndex = i + 1;
                this.Controls.Add(buttons[i]);
            }
            // txtDisplay
            this.Controls.Add(this.txtDisplay);
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Name = "SimpleCalculatorForm";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
