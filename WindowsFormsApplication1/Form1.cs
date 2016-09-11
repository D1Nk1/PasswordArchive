using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool authorized = false;

        public Form1()
        {
            InitializeComponent();
        }


        string username = "admin";
        string password = "admin";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)

            {
                MessageBox.Show("Logged in successfully!");
                authorized = true;
            }

            else

            {
                MessageBox.Show("Invalid username or password");
            }
            Close();
        }

    }
}
