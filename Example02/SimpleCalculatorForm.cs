using System;
using System.Windows.Forms;
using System.Globalization;

namespace Example02
{
    public partial class SimpleCalculatorForm : Form
    {
        double lastValue = 0;
        string lastOp = "";
        bool isNew = true;

        public SimpleCalculatorForm()
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
                case "+": case "-": case "*": case "/":
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
                    }
                    txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
                    isNew = true;
                    break;
            }
        }
    }
}
