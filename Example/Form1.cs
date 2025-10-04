using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add event handlers
            buttonOK1.Click += ButtonOK1_Click;
            buttonOK2.Click += ButtonCancel_Click;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ButtonOK1_Click(object sender, EventArgs e)
        {
            string info =
                $"Name: {textBoxName.Text}\n" +
                $"Number: {numericUpDown1.Value}\n" +
                $"CheckBox1: {checkBox1.Checked}\n" +
                $"RadioButton1: {radioButton1.Checked}\n" +
                $"ComboBox: {comboBox1.SelectedItem}\n" +
                $"Date: {dateTimePicker1.Value.ToShortDateString()}\n" +
                $"ListBox: {listBox1.SelectedItem}";
            MessageBox.Show(info, "Form Info");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"CheckBox1 checked: {checkBox1.Checked}");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"RadioButton1 checked: {radioButton1.Checked}");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"ComboBox selected: {comboBox1.SelectedItem}");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"ListBox selected: {listBox1.SelectedItem}");
        }
    }
}
