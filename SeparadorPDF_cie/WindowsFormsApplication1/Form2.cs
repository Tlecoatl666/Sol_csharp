using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        FormPrincipal sd;

        public Form2()
        {
            InitializeComponent();
            this.labellisto.Visible = false;
        }

        public Form2(FormPrincipal s)
        {
            InitializeComponent();
           // this.groupBox2.Visible = false;
            this.labellisto.Visible = false;
            sd = s;
            this.AutoSizeMode = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dlAbrir.CheckFileExists = true;
            dlAbrir.CheckPathExists = true;
            dlAbrir.Multiselect = false;
            dlAbrir.DefaultExt = "exp";
            dlAbrir.FileName = "";
            dlAbrir.Filter = "Archivos EXP (*.exp)|*.exp|Todos los archivos (*.*)|*.*";
            dlAbrir.Title = "Seleccionar fichero txt a dividir y separar páginas";
            if (dlAbrir.ShowDialog() == DialogResult.OK)
            {
                txtorigentxt.Text = dlAbrir.FileName;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dlAbrir.CheckFileExists = true;
            dlAbrir.CheckPathExists = true;
            dlAbrir.Multiselect = false;
            dlAbrir.DefaultExt = "pdf";
            dlAbrir.FileName = "";
            dlAbrir.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            dlAbrir.Title = "Seleccionar fichero PDF a dividir y separar páginas";
            if (dlAbrir.ShowDialog() == DialogResult.OK)
            {
                txtorigenpdfcie.Text = dlAbrir.FileName;
            }  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dlCarpeta.RootFolder = System.Environment.SpecialFolder.Desktop;
            dlCarpeta.ShowNewFolderButton = true;
            dlCarpeta.Description = "Selecciona la carpeta de destino de los ficheros " +
                    "PDF resultantes de extraer cada página del PDF " +
                    "origen en un fichero PDF destino";
            if (dlCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtdestinocie.Text = dlCarpeta.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String txtpath="", pdfpath="", destino="";
            
            txtpath = txtorigentxt.Text;
            pdfpath = txtorigenpdfcie.Text;
            destino = txtdestinocie.Text;


            if (txtpath == "" || pdfpath == "" || destino == "")
            {
                MessageBox.Show("Existen campos vacíos", "Aviso!");
            }
            else
            {
                ReadCIE rc = new ReadCIE();
                rc.LeerTxt(txtpath, pdfpath, destino);
                this.labellisto.Visible = true;
                txtdestinocie.Text = "";
                txtorigenpdfcie.Text = "";
                txtorigentxt.Text = "";
                Process.Start("explorer.exe", destino);
                
                this.Hide();
                //this.Dispose();
                sd.Show();


                

            }

            
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }





        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("adios lukas");
            //Application.Exit();
            this.Hide();
            sd.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }




    }
}
