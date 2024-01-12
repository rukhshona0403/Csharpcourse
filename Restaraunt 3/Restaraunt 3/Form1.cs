using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaraunt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cook cook = new Cook();
        Server server = new Server();   
        TableRequests tableRequests = new TableRequests();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource=new string[] {nameof(NoDrink),nameof(Pepsi),nameof(Tea),nameof(Coffee),nameof(CocaCola)};

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chickenQuantity = Convert.ToInt32(textBox1.Text);
            int eggQuantity = Convert.ToInt32(textBox2.Text);
            string drink = comboBox1.SelectedText;
            
            server.ReceiveRequest(server.customerCounter, chickenQuantity, eggQuantity,drink);

            var request = new TableRequests();
            request[89]
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Send();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server.Serve();
        }
    }
}
