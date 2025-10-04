using System;
using System.Windows.Forms;
using System.Globalization;

namespace Example02
{
    public partial class AdvancedCalculatorForm : Form
    {
        double memory = 0;
        double lastValue = 0;
        string lastOp = "";
        bool isNew = true;

        public AdvancedCalculatorForm()
        {
            InitializeComponent();
            foreach (var btn in buttons)
            {
                btn.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string text = btn.Text;
            switch (text)
            {
                case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9":
                    if (isNew || txtDisplay.Text == "0") txtDisplay.Text = text;
                    else txtDisplay.Text += text;
                    isNew = false;
                    break;
                case ".":
                    if (!txtDisplay.Text.Contains(".")) txtDisplay.Text += ".";
                    isNew = false;
                    break;
                case "+": case "-": case "*": case "/": case "%":
                    lastValue = double.TryParse(txtDisplay.Text, out double v) ? v : 0;
                    lastOp = text;
                    isNew = true;
                    break;
                case "=":
                    double cur = double.TryParse(txtDisplay.Text, out double v2) ? v2 : 0;
                    double result = lastValue;
                    switch (lastOp)
                    {
                        case "+": result += cur; break;
                        case "-": result -= cur; break;
                        case "*": result *= cur; break;
                        case "/": result = cur != 0 ? result / cur : 0; break;
                        case "%": result = result * cur / 100.0; break;
                    }
                    txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
                    isNew = true;
                    break;
                case "C":
                    txtDisplay.Text = "0";
                    lastValue = 0;
                    lastOp = "";
                    isNew = true;
                    break;
                case "CE":
                    txtDisplay.Text = "0";
                    isNew = true;
                    break;
                case "?":
                    if (txtDisplay.Text.Length > 1)
                        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    else
                        txtDisplay.Text = "0";
                    break;
                case "±":
                    if (double.TryParse(txtDisplay.Text, out double neg))
                        txtDisplay.Text = (-neg).ToString(CultureInfo.InvariantCulture);
                    break;
                case "?":
                    if (double.TryParse(txtDisplay.Text, out double sqrt))
                        txtDisplay.Text = sqrt >= 0 ? Math.Sqrt(sqrt).ToString(CultureInfo.InvariantCulture) : "0";
                    break;
                case "1/x":
                    if (double.TryParse(txtDisplay.Text, out double inv))
                        txtDisplay.Text = inv != 0 ? (1.0 / inv).ToString(CultureInfo.InvariantCulture) : "0";
                    break;
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    txtDisplay.Text = memory.ToString(CultureInfo.InvariantCulture);
                    isNew = true;
                    break;
                case "MS":
                    memory = double.TryParse(txtDisplay.Text, out double ms) ? ms : 0;
                    break;
                case "M+":
                    memory += double.TryParse(txtDisplay.Text, out double mp) ? mp : 0;
                    break;
                case "M-":
                    memory -= double.TryParse(txtDisplay.Text, out double mm) ? mm : 0;
                    break;
            }
        }
    }
}
