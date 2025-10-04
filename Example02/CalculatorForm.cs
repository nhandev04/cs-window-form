using System;
using System.Windows.Forms;
using System.Drawing;

namespace Example02
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            // Set font for form and controls
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtX.Font = this.Font;
            txtY.Font = this.Font;
            txtResult.Font = this.Font;
            btnAdd.Font = this.Font;
            btnMultiply.Font = this.Font;
            btnExit.Font = this.Font;
            btnSave.Font = this.Font;
            lblX.Font = this.Font;
            lblY.Font = this.Font;
            lblResult.Font = this.Font;

            btnAdd.Click += BtnAdd_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnExit.Click += BtnExit_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                txtResult.Text = $"{x} + {y} = {x + y}";
            }
            else
            {
                txtResult.Text = "Vui lòng nh?p s? h?p l?!";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                txtResult.Text = $"{x} * {y} = {x * y}";
            }
            else
            {
                txtResult.Text = "Vui lòng nh?p s? h?p l?!";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("?ã l?u k?t qu?!", "Thông báo");
        }
    }
}
