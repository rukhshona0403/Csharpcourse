using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        bool res = false;
        bool send = true;
        public Form1()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Drinks.NoDrink);
            comboBox1.Items.Add(Drinks.Coffee);
            comboBox1.Items.Add(Drinks.Tea);
            comboBox1.Items.Add(Drinks.Pepsi);
            comboBox1.Items.Add(Drinks.Water);
            comboBox1.SelectedItem = Drinks.Tea;
            comboBox1.SelectedIndex = 0;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                res = true;
                send = true;
                int quantityCh = 0;
                if(!int.TryParse(textBox1.Text, out quantityCh))
                {
                    MessageBox.Show("Please enter correct number on chicken count");
                }
                int quantityEg = 0;
                if(!int.TryParse(textBox2.Text, out quantityEg))
                {
                    MessageBox.Show("Please enter correct number on egg count");
                }
                server.Request(quantityCh, quantityEg, comboBox1.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (res && send)
            {
                listBox1.Items.Clear();
                send = !send;
                server.Send();
                label4.Text = server.Inspect().ToString();
            }
            else MessageBox.Show("Request has never been called before");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (res && send == false)
            {
                listBox1.Items.Clear();
                send = !send;
              string javob= server.Serve();
                
                listBox1.Items.Add(javob);
                res = false;
                for (int i = 0; i < server.count; i++)
                {
                    server.i = i;
                    listBox1.Items.Add("Please enjoy your food");
                    server.i = 0;
                    server.count = 0;
                }
            }
                else MessageBox.Show("The food is prepared, the employee cannot be prepare it again or Request has never been called before");
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int quantityEg { get; set; }

        public object result { get; set; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
