using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaraun_part__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cook cook = new Cook();
        Server server = new Server();
        TableRequest tableRequests = new TableRequest();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Drinks));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chickenQuantity = Convert.ToInt32(textBox1.Text);
            int eggQuantity = Convert.ToInt32(textBox2.Text);
            string drink = comboBox1.SelectedText;

            server.ReceiveRequest(server.customerCounter, chickenQuantity, eggQuantity, drink);

            var request = new TableRequest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Send();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server.Serve(server.GetSingleRequest());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
