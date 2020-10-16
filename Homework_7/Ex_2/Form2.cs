using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public delegate void MyDelegate(int s);
        public event MyDelegate MyDelegateEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
                MyDelegateEvent(number);
            else
            {
                MessageBox.Show("Введите число!");
                textBox1.Text = "";
            }
        }
    }
}
