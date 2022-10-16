using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            textBox1.Focus();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text !="")

            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")

            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")

            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")

            {

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1/num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }
    }
}
