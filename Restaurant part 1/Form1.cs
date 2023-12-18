using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_part_1
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        object order;
        string MenuItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(textBox1.Text);
                order = employee.NewRequest(quantity, MenuItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            string inspect = employee.Inspect(order);
            label3.Text = inspect;
            Foods.Items.Clear();
            if (order == null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                Foods.Items.Add("Order Accepted!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                order = employee.CopyRequest();
                string inspect = employee.Inspect(order);
                label3.Text = inspect;
                Foods.Items.Add("Order is Copied!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = employee.PrepareFood(order);
                Foods.Items.Add(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MenuItem = eggRadioBtn.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MenuItem = chickenRadioBtn.Text;
        }
    }
}
