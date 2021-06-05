using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox3.Text);
            int res;
            using (SR1.Service1Client W = new SR1.Service1Client())
            {
                res = W.F4(x,y);
            }
            label1.Text = "Result:  " + res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SR1.Service1Client W = new SR1.Service1Client())
            {
                DataTable t1 = W.GetAllKinds();
                dataGridView1.DataSource = t1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SR1.Service1Client W = new SR1.Service1Client())
            {
                DataTable t1 = W.GetKindByID(textBox2.Text);
                dataGridView1.DataSource = t1;
            }
        }

    }
}
