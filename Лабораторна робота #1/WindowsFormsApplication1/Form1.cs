using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;




namespace WindowsFormsApplication1
{
    

    public partial class Form1 : Form
    {
        int z;
        float o1, o2, r;
        
        public Form1()
        {
            InitializeComponent();
            o1 = 0;
            o2 = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
            textBox2.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void btnMINUS_Click(object sender, EventArgs e)
        {
            textBox2.Text += "-";
           float.TryParse(textBox1.Text, out o1);
            z = 2;
            textBox1.Clear();
        }

        private void btnMUL_Click(object sender, EventArgs e)
        {
            textBox2.Text += "*";
            float.TryParse(textBox1.Text, out o1);
            z = 3;
            textBox1.Clear();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            textBox2.Text += "/";
            float.TryParse(textBox1.Text, out o1);
            z = 4;
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ravno();
            textBox1.Text = r.ToString();
            textBox2.Text += "=" + r.ToString();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "+";
            float.TryParse(textBox1.Text,out o1);
            z = 1;
            textBox1.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetAutorunValue(true);
        }
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue("name", ExePath);
                else
                    reg.DeleteValue("name");

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void ravno()
        {
            float.TryParse(textBox1.Text, out o2);
            switch (z)
            {
                case 1:
                    r = o1 + o2;
                    break;
                case 2:
                    r = o1 - o2;
                    break;
                case 3:
                    r = o1 * o2;
                    break;
                case 4:
                    r = o1 / o2;
                    break;
            }
            o1 = r;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
