﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using xNet;

namespace Lab_4_GET_request
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var request = new HttpRequest())
            {
                var reqParams = new RequestParams();
                request.CharacterSet = Encoding.GetEncoding(1251);

                reqParams["user"] = "Сотниченко";
                reqParams["pass"] = "777";

                string content = request.Post(
                    "http://www.zapomnika.zzz.com.ua/Lab4.php", reqParams).ToString();
                //int endStr = content.IndexOf("<");
                content = content.Substring(0, content.IndexOf("<"));
                textBox1.Text = content;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
