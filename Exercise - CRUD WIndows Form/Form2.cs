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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'helmDataSet.AGV' table. You can move, or remove it, as needed.
            this.aGVTableAdapter.Fill(this.helmDataSet.AGV);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
