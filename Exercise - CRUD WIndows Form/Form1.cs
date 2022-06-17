using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise___CRUD_WIndows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'helmDataSet.Arai' table. You can move, or remove it, as needed.
            this.araiTableAdapter.Fill(this.helmDataSet.Arai);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();

            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Arai_insert'"+int.Parse(textBox1.Text)+"','"+textBox2.Text+ "',,'" + textBox3.Text + ", con);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
