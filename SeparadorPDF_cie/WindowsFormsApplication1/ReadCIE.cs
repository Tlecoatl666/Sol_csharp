using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ReadCIE
    {


        public void LeerTxt(String origentxt,String origenpdf,String destinopdf)
        {
            try
            {
                using (StreamReader sr = new StreamReader(origentxt, false))
                {
                    PdfReader reader = new PdfReader(origenpdf);
                    int nPaginasPDF = reader.NumberOfPages;
                    string linecont;
                    int nlineastxt = 0;
                    while((linecont=sr.ReadLine()) != null)
                    {

                        if (linecont.Contains("CANCELADO") || linecont.Contains("LINEA") || linecont.Contains("EIE"))
                        {
                            ///si esta cancelado entonces no contamos esta linea del txt
                        }
                        else
                        {
                            nlineastxt = nlineastxt + 1;
                        }
                        
                    }


                    if(nlineastxt != nPaginasPDF)
                    {
                        MessageBox.Show("El archivo de texto no coincide con el PDF ingresado");
                    }
                    else
                    {
                        goLeerTxtporLinea( origentxt,  origenpdf,  destinopdf);
                    }


                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }
           // Console.ReadKey();
        }

        private void goLeerTxtporLinea(String origentxt, String origenpdf, String destinopdf)
        {
            //using (StreamReader sr = new StreamReader("C:\\DetallePagos.exp", false))
            using (StreamReader sr = new StreamReader(origentxt, false))
            {

                string line;
                int hoja = 1;
                while ((line = sr.ReadLine()) != null)
                {

                    //Console.WriteLine(line);

                    //Si una linea del exp (txt) dice : CANCELADO  POR EL USUARIO
                    //saltatelo por qu eno viene en el pdf
                    //12/09/2018 se puso un OR en el IF , existen lineas en el txt de cancelado que no dicen "CANCELADO" dice "LINEA DE C"     
                    //18/10/2018 se puso IMPORTE  , pero se cambio por EIE que puede ser la clave de cancelacion
                    //esperemos que no se repita EIE en la misma linea del txt sino se lo va a saltar
                    if (line.Contains("CANCELADO") || line.Contains("LINEA") || line.Contains("EIE"))
                    {
                        ///si esta cancelado entonces no esta en el pdf

                        Console.WriteLine("Hoja saltada: " + hoja);
                        Console.WriteLine("Cancelado! DESDE ANTES");

                    }
                    else
                    {
                        TrabajarLine(hoja, line, origenpdf, destinopdf);
                        hoja++;
                    }
                }
            }
        }

        private void TrabajarLine(int hoja,String line,String origenpdf,String destinopdf)
        {
            //este es el numero de guia , la posicion 85 , tomas los 7 siguientes
           
            String guia= line.Substring(84,7);//modificacion 28 de junio
           // este era el original String guia = line.Substring(85, 7);//modificacion 28 de junio
           //String Npago = line.Substring(108, 10);

           int index = line.IndexOf(".");

           
           
            //aca se hace la misma comparacion de la linea por si acaso
           if (line.Contains("CANCELADO"))
           {
               ///si esta cancelado entonces no esta en el pdf
               Console.WriteLine("Cancelado!");

           }
           else
           {
               String Npago = line.Substring(index + 3, 10);
               Console.WriteLine("Numero guia:" + guia + " Numero pago: " + Npago);



               PartirPDF par = new PartirPDF();

               par.MetodoConTxt(hoja, Npago, origenpdf, destinopdf);
           }
          
            
           


        }





    }
}
