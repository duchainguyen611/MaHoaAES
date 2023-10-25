using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public static double gcd(double a, double h)
        {
           
            double temp;
            while (true)
            {
                temp = a % h;
                if (temp == 0)
                    return h;
                a = h;
                h = temp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            double p = double.Parse(txt_p.Text);
            double q = double.Parse(txt_q.Text);
            double b = double.Parse(txt_b.Text);

            double n = p * q;
            double phi = (p - 1) * (q - 1);
            while (b < phi)
            {
                
                if (gcd(b, phi) == 1)
                    break;
                else
                    b++;
            }
            int k = 2; // A constant value
            double d = (1 + (k * phi)) / b;

            // Message to be encrypted
            double msg = double.Parse(txt_msg.Text);

            rtb.Text += "Message data = "
                              + String.Format("{0:F6} \n", msg);

            // Encryption c = (msg ^ e) % n
            double c = Math.Pow(msg, b);
            c = c % n;
            rtb.Text +=  "Encrypted data = "
                              + String.Format("{0:F6}\n", c);

            // Decryption m = (c ^ d) % n
            double m = Math.Pow(c, d);
            m = m % n;
            rtb.Text += "Original Message Sent = "
                              + String.Format("{0:F6}\n", m);
        }

    }
}
    

