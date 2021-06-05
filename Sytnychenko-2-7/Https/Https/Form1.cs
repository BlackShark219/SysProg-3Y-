using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Https
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client service = new SR.Service1Client())
            {
                label1.Text = service.MyIPAddress();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client service = new SR.Service1Client())
            {
                if (service.IsLoginFree(textBox1.Text))
                    label3.Text = "YES!!!";
                else
                    label3.Text = "NO!!!";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
