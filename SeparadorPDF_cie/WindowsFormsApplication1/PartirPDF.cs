using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class PartirPDF
    {

        public int MetodoPrinc(String PathOrigen,String PathDestino,int IndexBanco)
        {
            int resp = 0;
            //string pdfFilePath = @"C:\PdfFiles\sample.pdf";
            string pdfFilePath = @""+PathOrigen;
            //string outputPath = @"C:\SplitedPdfFiles";
            string outputPath = @""+PathDestino;
            int interval = 1;//de a como va a ir la pagina
            int pageNameSuffix = 0;

            // Intialize a new PdfReader instance with the contents of the source Pdf file:
            PdfReader reader = new PdfReader(pdfFilePath);

            FileInfo file = new FileInfo(pdfFilePath);

            //este lleva nombre del pdf
            //string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";
            string pdfFileName = "";
            //Program obj = new Program(); //no es necesario crear un objeto de la clase si el metodo ya esta dentro


            string resultado;
            Busquedas bu = new Busquedas();
            resultado = bu.ExtractTextFromPdf(1, pdfFilePath);//Regresa el texto ya sabe de que pagina

            int indexBancomer = resultado.IndexOf("BBVA Net Cash");
            int indexOldBancomer = resultado.IndexOf("Bancomer");
            int indexBanorte = resultado.IndexOf("BANCO MERCANTIL DEL NORTE");
            int tipopdf = 0;

            if (indexBancomer>=0 || indexOldBancomer>=0  )
            {
                tipopdf = 1;
            }
            if (indexBanorte >= 0)
            {
                tipopdf = 2;
            }

            if (tipopdf == IndexBanco)
            {
                
                Form1 u = new Form1();
                ///Este for es el que saca todooooooooooo

                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
                {
                    pdfFileName = u.MakePDF(pageNumber, pdfFilePath, IndexBanco);
                    pageNameSuffix++;
                    //  string newPdfFileName = string.Format(pdfFileName + "{0}", pageNameSuffix);
                    SplitAndSaveInterval(pdfFilePath, outputPath, pageNumber, interval, pdfFileName);
                }
                resp = 1;
            }
            else
            {
                MessageBox.Show("Revise que el archivo PDF coincida con el banco seleccionado e intente de nuevo ");
                resp = 0;
            }




            return resp;
        }

        public void MetodoConTxt(int hoja , String numeropago,String origenpdf , String destinopdf )
        {
            //las mismas variables que en el otro
            //string pdfFilePath = @"C:\PdfFiles\cies7.pdf";
            //string outputPath = @"C:\SplitedPdfFiles";
            string pdfFilePath = @""+origenpdf;
            string outputPath = @""+destinopdf;
            int interval = 1;//de a como va a ir la pagina
            int pageNameSuffix = 0;

            // Intialize a new PdfReader instance with the contents of the source Pdf file:
            PdfReader reader = new PdfReader(pdfFilePath);

            FileInfo file = new FileInfo(pdfFilePath);

            //este lleva nombre del pdf
            //string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";
            string pdfFileName = "";
            //Program obj = new Program(); //no es necesario crear un objeto de la clase si el metodo ya esta dentro



            Console.WriteLine("Aqui si llega numero 1");

            Form1 u = new Form1();

            //for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
            //{
                pdfFileName = u.MakePDFTxt(hoja, pdfFilePath,numeropago);
                pageNameSuffix++;
                //    string newPdfFileName = string.Format(pdfFileName + "{0}", pageNameSuffix); se quita el numero de hoja que trae pageNameSuffix
                SplitAndSaveInterval(pdfFilePath, outputPath, hoja, interval, pdfFileName);
            //}
        }


        private void SplitAndSaveInterval(string pdfFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                //PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + "PRUEBAS"+ startPage + ".pdf", FileMode.Create));
                document.Open();

                for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                {
                    if (reader.NumberOfPages >= pagenumber)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                    }
                    else
                    {
                        break;
                    }

                }

                document.Close();
            }
        }






    }
}
