using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            kezdolap1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            kezdolap1.BringToFront();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            masodikoldal1.BringToFront();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            harmadikoldal1.BringToFront();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            negyedikoldal1.BringToFront();
        }
        
        private void Button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kilépés?", "Kilépés", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            //this.Close();
        }
        
        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instagram.com");
        }
        

        private bool mouseDown;
        private Point lastLocation;
        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }          
        }

        

    }
}
