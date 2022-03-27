using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2_
{
    public partial class Form2 : Form
    {
        public static bool isReady = false;
        public static bool isRandomColor = false;
        public static bool ClearCanvas = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.q = Int32.Parse(textBox1.Text);
                isReady = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isRandomColor = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClearCanvas = true;
        }
    }
}
