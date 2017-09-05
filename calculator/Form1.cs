using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap MyImage = new Bitmap(Application.StartupPath + @"\2.bmp");
            
            pictureBox1.ClientSize = new Size(MyImage.Width, MyImage.Height);
            pictureBox1.Image = (Image)MyImage;
        }
        public string solvethis = "";
        private void button1_Click(object sender, EventArgs e)
        {
            solvethis += "1";
            label1.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            solvethis += "2";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solvethis += "3";
            label1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((solvethis[solvethis.Length - 1] == '+') ||
                (solvethis[solvethis.Length - 1] == '-') ||
                (solvethis[solvethis.Length - 1] == '*') ||
                (solvethis[solvethis.Length - 1] == '/'))
            {
                string a = solvethis;
                solvethis = a.Remove(a.Length - 1, 1);
                label1.Text = a.Remove(a.Length - 1, 1);
            }
            solvethis += "+";
            label1.Text += "+";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char[] a = solvethis.ToCharArray();
            string line1="";
            string line2="";
            char sign=' ';
            
            for (int i = 0; i < solvethis.Length; i++)
            {
                
                 if ((a[i] == '+') ||
                     (a[i] == '-') ||
                     (a[i] == '*') ||
                     (a[i] == '/'))
                 {
                    sign = a[i];
                    line1 = solvethis.Substring(0,i);
                    line2 = solvethis.Substring(i+1, solvethis.Length-i-1);
                 }

            }

            int r = 0;
            if (sign=='+')
            {
                r = Convert.ToInt32(line1) + Convert.ToInt32(line2);
                label1.Text += "=" + Convert.ToString(r);
                solvethis += "=" + Convert.ToString(r);
            }
            else if (sign == '-')
            {
                r = Convert.ToInt32(line1) - Convert.ToInt32(line2);
                label1.Text += "=" + Convert.ToString(r);
                solvethis += "=" + Convert.ToString(r);
            }
            else if (sign == '*')
            {
                r = Convert.ToInt32(line1) * Convert.ToInt32(line2);
                label1.Text += "=" + Convert.ToString(r);
                solvethis += "=" + Convert.ToString(r);
            }
            

            if (sign == '/')
            {
                if (line2=="0")
                {
                    label1.Text = "errror";
                    solvethis = "";
                }
                else
                {
                    r = Convert.ToInt32(line1) / Convert.ToInt32(line2);
                    label1.Text += "=" + Convert.ToString(r);
                    solvethis += "=" + Convert.ToString(r);
                }
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            solvethis += "0";
            label1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            solvethis += "4";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            solvethis += "5";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            solvethis += "6";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            solvethis += "7";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            solvethis += "8";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            solvethis += "9";
            label1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((solvethis[solvethis.Length - 1] == '+') ||
                (solvethis[solvethis.Length - 1] == '-') ||
                (solvethis[solvethis.Length - 1] == '*') ||
                (solvethis[solvethis.Length - 1] == '/'))
            {
                string a = solvethis;
                solvethis = a.Remove(a.Length - 1, 1);
                label1.Text = a.Remove(a.Length - 1, 1);
            }
            solvethis += "-";
            label1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((solvethis[solvethis.Length - 1] == '+') ||
                (solvethis[solvethis.Length - 1] == '-') ||
                (solvethis[solvethis.Length - 1] == '*') ||
                (solvethis[solvethis.Length - 1] == '/'))
            {
                string a = solvethis;
                solvethis = a.Remove(a.Length - 1, 1);
                label1.Text = a.Remove(a.Length - 1, 1);
            }
            solvethis += "*";
            label1.Text += "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((solvethis[solvethis.Length - 1] == '+') ||
                   (solvethis[solvethis.Length - 1] == '-') ||
                   (solvethis[solvethis.Length - 1] == '*') ||
                   (solvethis[solvethis.Length - 1] == '/'))
            {
                string a = solvethis;
                solvethis = a.Remove(a.Length - 1, 1);
                label1.Text = a.Remove(a.Length - 1, 1);
            }
            solvethis += "/";
            label1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            solvethis = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string a = solvethis;
            solvethis = a.Remove(a.Length - 1, 1);
            label1.Text = a.Remove(a.Length - 1, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char[] a = solvethis.ToCharArray();
            for (int i = 0; i < solvethis.Length; i++)
            {
                if (a[i] == '=')  
                {
                    string f = solvethis;
                    solvethis = f.Substring(i + 1, f.Length - i - 1);
                    label1.Text = f.Substring(i + 1, f.Length - i - 1);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
