using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projekt
{
    public partial class harmadikoldal : UserControl
    {
        public harmadikoldal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            negyedikoldal.name = label1.Text;
            negyedikoldal.price = int.Parse(label2.Text);
            negyedikoldal.quantity = int.Parse(textBox1.Text);
            negyedikoldal.isChanged = true;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
                return;
            negyedikoldal.name = label4.Text;
            negyedikoldal.price = int.Parse(label5.Text);
            negyedikoldal.quantity = int.Parse(textBox2.Text);
            negyedikoldal.isChanged = true;
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Számot üss be!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        
    }
}
