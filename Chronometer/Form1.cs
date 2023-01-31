using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int ms = 0;
        private int secound = 0;
        private int minuts = 0;
        private int hours = 0;

        private bool status = false;

        public Form1()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private string getValue(int number)
        {
            if (number < 10) return String.Format("0{0}", number);
            else return number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = !status;
            button1.Text = status ? "Stop" : "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();

            if (status)
            {
                ms++;

                if (ms == 60)
                {
                    ms = 0;
                    secound++;
                }

                if (secound == 60)
                {
                    secound = 0;
                    minuts++;
                }

                if (minuts == 60)
                {
                    minuts = 0;
                    hours++;
                }
            }

            label1.Text = String.Format("{0} : {1} : {2} : {3}",
                getValue(hours), getValue(minuts), getValue(secound), getValue(ms));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ms = 0;
            secound = 0;
            minuts = 0;
            hours = 0;
        }
    }
}
