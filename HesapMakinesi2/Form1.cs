using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi2
{
    public partial class Form1 : Form
    {

        double x,y;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if(textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            y=Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text=Convert.ToString(x+y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x-y);
                label1.Text = "";
            }
            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x*y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x/y);
                label1.Text = "";
            }
            if(islem == "mod")
            {
                textBox1.Text=Convert.ToString(x%y);
                label1.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "x";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void buttonkre_Click(object sender, EventArgs e)
        {
            double kare=Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void btnkok_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void btnblu_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(textBox1.Text);
            bolumx = 1/(bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text=textBox1.Text +"(mod)";
            textBox1.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text= "";
        }
    }
}
