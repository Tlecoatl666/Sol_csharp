using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FormPrincipal sd;

        public Form1()
        {
            InitializeComponent();
            this.groupBox2.Visible=false;
            this.labellisto.Visible = false;
        }

        public Form1(FormPrincipal s)
        {
            InitializeComponent();
            this.groupBox2.Visible = false;
            this.labellisto.Visible = false;
            sd = s;
            this.AutoSizeMode = 0;
            this.ComboBanco.SelectedIndex = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
       {
            //Console.WriteLine("Este es el main ?");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txtpath = txtorigentxt.Text;
            String pdfpath = txtorigenpdfcie.Text;
            String destino = txtdestinocie.Text;

            ReadCIE rc = new ReadCIE();
            rc.LeerTxt(txtpath,pdfpath,destino);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int IndexBanco = this.ComboBanco.SelectedIndex;

            if (IndexBanco==0)
            {

                MessageBox.Show("Selecciona un banco", "Aviso!");
            }
            else
            {
                String origen = "", destino = "";

                origen = TxtPathOrigen.Text;
                destino = TxtDestinopdf.Text;

                if (origen == "" || destino == "")
                {

                    MessageBox.Show("Existen campos vacíos", "Aviso!");

                }
                else
                {
                    PartirPDF cut = new PartirPDF();
                    int respuesta=cut.MetodoPrinc(origen, destino,IndexBanco);//aqui le mando el index de banco , si es 1 todo igual si es 2 cambia tipo banorte 


                    if (respuesta==1)
                    {
                        this.labellisto.Visible = true;
                        TxtPathOrigen.Text = "";
                        TxtDestinopdf.Text = "";
                        Process.Start("explorer.exe", destino);
                        this.Hide();
                        sd.Show();
                    }

                    



                }
            }



            

        }


        public String MakePDF(int Npage,String pathPDF,int IndexBanco) {

            Busquedas bus = new Busquedas();
             //dentro del boton 
            // Conection con = new Conection();
            // String hola = con.conectar("Select top 1 CodEmpresa from CuentasAcorde");
            // label1.Text = hola;
            String CodEmpresaYCuenta5 = "";
            String FechaApli = "";
            String MotivoPago = "";
            String CadenaPDF = "";
            



            if (IndexBanco == 1)
            {//bancomer
             //Aqui voy buscando dentro del pdf cada numero 
                
                    CodEmpresaYCuenta5 = bus.buscaretiro(Npage, pathPDF);//aqui llega el cod de empresa y ultimos 5 de cuenta ret
                if (CodEmpresaYCuenta5 == "BLANCO_")
                {
                    //si no hay cuenta y empresa entonces la pagina esta en blanco o no encontro el index en la hoja .......
                }
                else
                {


                    MotivoPago = bus.buscamotivo(Npage, pathPDF);
                    FechaApli = bus.buscafecha(Npage, pathPDF);
                    //trae codigo de empresa por Cuenta
                }



            }
            if (IndexBanco == 2)
            {//banorte
             //Aqui voy buscando dentro del pdf cada numero 
                
                    CodEmpresaYCuenta5 = bus.buscaretiroBanorte(Npage, pathPDF);//aqui llega el cod de empresa y ultimos 5 de cuenta ret

                if (CodEmpresaYCuenta5=="BLANCO_")
                {
                    //si no hay cuenta y empresa entonces la pagina esta en blanco o no encontro el index en la hoja .......
                }
                else
                {

                    MotivoPago = bus.buscamotivoBanorte(Npage, pathPDF);
                    FechaApli = bus.buscafechaBanorte(Npage, pathPDF);
                    //trae codigo de empresa por Cuenta
                }


            }





            CadenaPDF = CodEmpresaYCuenta5 + "_" + FechaApli + MotivoPago;
            //Blanco__

            //Console.WriteLine(CadenaPDF);
            //label1.Text = CadenaPDF;


            //Console.ReadLine();
            return CadenaPDF;
        }




        public String MakePDFTxt(int Npage, String pathPDF,String numeropago)
        {

            Busquedas bus = new Busquedas();
            //dentro del boton 
            // Conection con = new Conection();
            // String hola = con.conectar("Select top 1 CodEmpresa from CuentasAcorde");
            // label1.Text = hola;



            String CodEmpresaYCuenta5 = "";
            String FechaApli = "";
            //String MotivoPago = "";
            String CadenaPDF = "";

            Console.WriteLine("Aqui si llega 2");
            //funcional
            CodEmpresaYCuenta5 = bus.buscaretiroCIE(Npage, pathPDF);//aqui llega el cod de empresa y ultimos 5 de cuenta ret
            //MotivoPago = bus.buscamotivo(Npage, pathPDF);
            FechaApli = bus.buscafecha(Npage, pathPDF);
            //trae codigo de empresa por Cuenta


            CadenaPDF = CodEmpresaYCuenta5 + "_" + FechaApli + numeropago;
                                                                //motivo de pago en el otro, (sustitucion)


            //Console.WriteLine(CadenaPDF);
            //label1.Text = CadenaPDF;


            //Console.ReadLine();
            return CadenaPDF;
        }

        private void button3_Click(object sender, EventArgs e)
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
                TxtPathOrigen.Text = dlAbrir.FileName;
            }     
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dlCarpeta.RootFolder = System.Environment.SpecialFolder.Desktop;
            dlCarpeta.ShowNewFolderButton = true;
            dlCarpeta.Description = "Selecciona la carpeta de destino de los ficheros " +
                    "PDF resultantes de extraer cada página del PDF " +
                    "origen en un fichero PDF destino";
            if (dlCarpeta.ShowDialog() == DialogResult.OK)
            {
                TxtDestinopdf.Text = dlCarpeta.SelectedPath;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("adios lukas");
            //Application.Exit();
            this.Hide();
            sd.Show();
        }



    }
}
