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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.AutoSizeMode=0;
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1(this);
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
            this.Hide();
            //this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();
            this.Hide();
            //this.Dispose();
        }


        private void txt1_KeyDown(object sender, EventArgs e)
        {

            Console.WriteLine("asfwrfsg");
        }


    }
}
