using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] {
                "Công nghệ thông tin",
                "Kế toán",
                "Cơ khí",
                "Điện",
                "Hóa"
            });
            comboBox1.SelectedIndex = 3; // Chọn sẵn "Điện"
        }
    }
}
