using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tolong isi text box terlebih dahulu");
            }
            else
            {
                string text = textBox1.Text;
                char[] reverse = text.ToCharArray();
                Array.Reverse(reverse);
                string hasil = new string(reverse);
                output.Text = hasil;
            }
           
        }

        private void urutkan_Click(object sender, EventArgs e)
        {
            char[] urutkan = Text.ToCharArray();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
