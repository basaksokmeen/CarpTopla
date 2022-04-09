using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double top =0;           

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int deger = Int16.Parse(listBox1.Items[i].ToString());
                if (deger % 2 == 1)
                {
                    top += Convert.ToDouble(listBox1.Items[i]);
                    label1.Text = "" + top;
                }
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = String.Empty;
            label2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " ");

            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int carp = 1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                carp *= Convert.ToInt32(listBox1.Items[i]);

                label2.Text = Convert.ToString(carp);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



    }
}
