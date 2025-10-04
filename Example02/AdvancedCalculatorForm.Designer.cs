using System.Windows.Forms;
using System.Drawing;

namespace Example02
{
    partial class AdvancedCalculatorForm
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
            this.buttons = new Button[28];
            this.SuspendLayout();
            // txtDisplay
            this.txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(440, 50);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            this.txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // Button labels
            string[] labels = {
                "MC", "MR", "MS", "M+", "M-",
                "DEL", "CE", "C", "±", "v-",
                "7", "8", "9", "/", "%",
                "4", "5", "6", "*", "1/x",
                "1", "2", "3", "-", "=",
                "0", ".", "+"
            };
            // Button positions
            int[,] positions = {
                {0,1}, {1,1}, {2,1}, {3,1}, {4,1},
                {0,2}, {1,2}, {2,2}, {3,2}, {4,2},
                {0,3}, {1,3}, {2,3}, {3,3}, {4,3},
                {0,4}, {1,4}, {2,4}, {3,4}, {4,4},
                {0,5}, {1,5}, {2,5}, {3,5}, {4,5},
                {0,6}, {1,6}, {2,6}
            };
            int btnWidth = 85, btnHeight = 45, marginX = 12, marginY = 75, spacing = 5;
            for (int i = 0; i < labels.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = labels[i];
                buttons[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                buttons[i].Size = new System.Drawing.Size(btnWidth, btnHeight);
                buttons[i].Location = new System.Drawing.Point(marginX + positions[i,0]*(btnWidth+spacing), marginY + positions[i,1]*(btnHeight+spacing));
                buttons[i].Name = "btn" + labels[i].Replace("/", "Div").Replace("*", "Mul").Replace("+", "Plus").Replace("-", "Minus").Replace("=", "Equal").Replace(".", "Dot").Replace("%", "Percent").Replace("?", "Sqrt").Replace("±", "Neg").Replace("?", "Back").Replace("1/x", "Inv");
                buttons[i].TabIndex = i+1;
                buttons[i].Anchor = AnchorStyles.Top | AnchorStyles.Left;
                this.Controls.Add(buttons[i]);
            }
            // txtDisplay
            this.Controls.Add(this.txtDisplay);
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 400);
            this.Name = "AdvancedCalculatorForm";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
