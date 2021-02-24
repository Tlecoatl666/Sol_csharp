using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Busquedas
    {


        public String buscamotivo(int hoja, String pathPDF)
        {
            string resultado;
            string buscacadena = "";
            int index;


            string resultadocadena = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
             resultado = ExtractTextFromPdf(hoja,pathPDF);
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            
            index = resultado.IndexOf("Motivo de pago: ");
            
            // TRAE EL NUMERO DE MOTIVO DE PAGO

            //**********************EDITADO 23 09 2019
            if (index<0)
            {
                
                //si es <0 el index , entonces no existe el MOTICO DE PAGO , y buscamos mejor CONCEPTO
                index = resultado.IndexOf("Concepto de pago: ");
                Console.WriteLine("index del CONCEPTO pago : " + index);
                for (int i = 18; i <= 27; i++)
                {
                    buscacadena = ((resultado[index + i]).ToString());
                    resultadocadena = resultadocadena + buscacadena.ToString();
                }

            }
            else
            {
                Console.WriteLine("index del MOTIVO pago : " + index);
                
                //si es motivo seguimos normalmente
                for (int i = 16; i <= 25; i++)
                {
                    buscacadena = ((resultado[index + i]).ToString());
                    resultadocadena = resultadocadena + buscacadena.ToString();
                }
            }

            //**********************EDITADO 23 09 2019




            //IMPRIME EL MOTIVO DE PAGO 
            Console.WriteLine(resultadocadena);
            return resultadocadena;
        }

        public String buscamotivoBanorte(int hoja, String pathPDF)
        {

            //Cambia reversa , ya que en numero de referencia de bancomer llega a cambiar de numero de digitos de 10 a 7 , 
            //por ello se realiza la extraccion hacia atras (reversa) igual que con el metodo anterior 


            string resultado;
            string buscacadena = "";
            int index;


            string resultadocadena = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja, pathPDF);
            //BUSCA UNA CADENA DENTRO DEL TEXTO

            index = resultado.IndexOf("Número de Referencia");

            // TRAE EL NUMERO DE MOTIVO DE PAGO
            Console.WriteLine("index del Número de Referencia : " + index);

            String espacio = "", cadenareversa = "";//creacion de nuevas variables
            int newindex = index + 21;//se aumenta 21 posiciones de : Número de Referencian_ (aqui empieza) 
            string nback = "\n";
            int indentiLongitudNR = 0;

            //**********************EDITADO 23 09 2019
            if (index < 0)
            {

                MessageBox.Show("Problema detectado en generación de nombre, No existe en numero de referencia en el PDF ");

            }
            else
            {

                
                while (espacio != " " && espacio != nback)
                {

                    //espacio es la variable que se va moviendo hasta encontrar un " " (espacio)
                    espacio = resultado[newindex].ToString();
                    //Console.WriteLine("espacio! : " + espacio);
                    newindex = newindex + 1; //aumento en uno para obtener el index del espacio (hasta que termine 00009987etc..)
                    indentiLongitudNR = indentiLongitudNR + 1;
                    Console.WriteLine("New index mio : " + newindex);
                }

                //al final new index tendra el index del espacio terminando el motivo pago

                String buscacadenarev = "";

                if (indentiLongitudNR>8)
                {
                    for (int j = 0; j <= 9; j++)//se le modifico de 11 a 9 por el "\n" que lo toma como 2 no se por que 
                    {
                        //del espacio voy recorriendo hacia atras y concatenando
                        buscacadenarev = ((resultado[newindex - j-2]).ToString());
                        cadenareversa = buscacadenarev.ToString() + cadenareversa;
                    }
                }
                else
                {
                    for (int j = 0; j <= 7; j++)//se le modifico de 11 a 9 por el "\n" que lo toma como 2 no se por que 
                    {
                        //del espacio voy recorriendo hacia atras y concatenando
                        buscacadenarev = ((resultado[newindex - j-2]).ToString());
                        cadenareversa = buscacadenarev.ToString() + cadenareversa;
                    }

                    cadenareversa = "000" + cadenareversa.Trim();//tienen que ser 101 a fuerza 

                }

               


            }

            //**********************EDITADO 23 09 2019




            //IMPRIME EL MOTIVO DE PAGO 
            Console.WriteLine(cadenareversa);
            return cadenareversa;
        }


        public String buscafechaBanorte(int hoja, String pathPDF)
        {
            string resultado;
            string buscacadena = "";
            string resultadocadena = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja, pathPDF);
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            int index = resultado.IndexOf("Fecha de Ejecución");//cambio nombre de fecha de aplicacion a jeecucion
            Console.WriteLine(index);
            Console.WriteLine(resultado[index]);
            // TRAE FECHA DE APLICACION
            //19 
            index = index +19; // se le aumentan 19 del fecha de ejecucion_
            for (int i = 0; i <= 12; i++)//12 espacios ya que la fecha esta 12/ago./2020
            {
                buscacadena = ((resultado[index + i]).ToString());
                resultadocadena = resultadocadena + buscacadena.ToString();

            }
            //IMPRIME EL MOTIVO DE PAGO 
            Console.WriteLine(resultadocadena);

            String ano = "", mes = "", dia = "";

            ano = resultadocadena.Substring(8, 4);

            mes = resultadocadena.Substring(3, 3);

            dia = resultadocadena.Substring(0, 2);//que pasa si el dia es del 1 al 9 ? , esta como 01 o 1 en el pdf ? 


            switch (mes)
            {
                case "ene":
                    mes = "01";
                    break;
                case "feb":
                    mes = "02";
                    break;
                case "mar":
                    mes = "03";
                    break;
                case "abr":
                    mes = "04";
                    break;
                case "may":
                    mes = "05";
                    break;
                case "jun":
                    mes = "06";
                    break;
                case "jul":
                    mes = "07";
                    break;
                case "ago":
                    mes = "08";
                    break;
                case "sep":
                    mes = "09";
                    break;
                case "oct":
                    mes = "10";
                    break;
                case "nov":
                    mes = "11";
                    break;
                case "dic":
                    mes = "12";
                    break;

                default:
                    mes = "00";
                    break;
            }



            return ano + mes + dia + "_";//regreso ya la fecha acomodada
            //return resultadocadena;
        }




        public String buscafecha(int hoja, String pathPDF)
        {
            string resultado;
            string buscacadena = "";
            string resultadocadena = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja, pathPDF);
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            int index = resultado.IndexOf("Fecha de aplicación: ");
            Console.WriteLine(index);
            Console.WriteLine(resultado[index]);
            // TRAE FECHA DE APLICACION
            for (int i = 21; i <= 30; i++)//aumente dos del 28 al 30 por que faltaban dos numeros en el ano de la fecha
            {
                buscacadena = ((resultado[index + i]).ToString());
                resultadocadena = resultadocadena + buscacadena.ToString();

            }
            //IMPRIME EL MOTIVO DE PAGO 
            Console.WriteLine(resultadocadena);

            String ano = "", mes = "", dia = "";

            ano = resultadocadena.Substring(6, 4);

            mes = resultadocadena.Substring(3, 2);

            dia = resultadocadena.Substring(0, 2);//que pasa si el dia es del 1 al 9 ? , esta como 01 o 1 en el pdf ? 

            /*
             
             * if (resultadocadena.Lenght()==10)
             * 
             * si es igual a 10 enonces usar substring normal , si son 9 usar un substring diferente
             
             */

            return ano + mes + dia + "_";//regreso ya la fecha acomodada
            //return resultadocadena;
        }


        public String buscaretiro(int hoja,String pathPDF)
        {
            string resultado="";
            string buscacadena = "";
            string resultadocadena = "";
            string CadenaCortada = "";
            string buscacadenarev = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja,pathPDF);//Regresa el texto ya sabe de que pagina!
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            int index = resultado.IndexOf("Cuenta de retiro: ");//cuenta clabe ordenante en BANCOMER


            if (index < 0)
            {
                resultado = "BLANCO";
            }
            else {

                Console.WriteLine(index);
                Console.WriteLine(resultado[index]);
                // TRAE FECHA DE APLICACION


                //////////////////////////////////////////////////
                String espacio = "", cadenareversa = "";//creacion de nuevas variables
                int newindex = index + 18;//se aumenta 18 posiciones de : cuenta de retiro:(aqui empieza) 

                while (espacio != " ")
                {

                    //espacio es la variable que se va moviendo hasta encontrar un " " (espacio)
                    espacio = resultado[newindex].ToString();
                    //Console.WriteLine("espacio! : " + espacio);
                    newindex = newindex + 1; //aumento en uno para obtener el index del espacio (hasta que termine 00009987etc..)

                    Console.WriteLine("New index mio : " + newindex);
                }

                //al final new index tendra el index del espacio terminando el motivo pago


                for (int j = 0; j <= 11; j++)
                {
                    //del espacio voy recorriendo hacia atras y concatenando
                    buscacadenarev = ((resultado[newindex - j]).ToString());
                    cadenareversa = buscacadenarev.ToString() + cadenareversa;
                }

                ////////////////////////////////////////////////


                for (int i = 18; i <= 28; i++)
                {
                    buscacadena = ((resultado[index + i]).ToString());
                    resultadocadena = resultadocadena + buscacadena.ToString();//Aqui esta cuenta retiro

                }
                //IMPRIME CUENTA
                //estos son las dos variables , la vieja y la nueva (reversa)
                Console.WriteLine("Como estaba: " + resultadocadena + " mi cadena rev: " + cadenareversa);
                Conection con = new Conection();
                //en el where cambi resultadocadena POR cadenareversa (la nueva)
                resultado = con.conectar("Select CodEmpresa from CuentasAcorde where Cuenta='" + cadenareversa + "'");// aqui ya es codempresa
                Console.WriteLine(resultado);

                //code aldo-------------------------------------------------------------------------------------

                //el mismo cambio de variables como en el where :
                CadenaCortada = cadenareversa.Substring(5, 5); // corta cuenta para buscaretiro

                //fin code aldo----------------------------------------------------------------------------------

                //CortaCuenta(resultadocadena); //ya no es necesario

            }




            return resultado + "_" + CadenaCortada; //ya tenemos codeigo de empresa + cuenta retiro (5 digitos)

        }



        public String buscaretiroBanorte(int hoja, String pathPDF)
        {
            string resultado="";
            string buscacadena = "";
            string resultadocadena = "";
            string CadenaCortada = "";
            string buscacadenarev = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja, pathPDF);//Regresa el texto ya sabe de que pagina!
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            int index = resultado.IndexOf("Cuenta/ CLABE Ordenante");//cuenta clabe ordenante en BANCOMER
            Console.WriteLine(index);

            if (index<0)
            {
                resultado = "BLANCO";//// edicion 04-09-2020 hay paginas en blanco
            }
            else
            {

                Console.WriteLine(resultado[index]);
                // TRAE FECHA DE APLICACION
                //+9

                //////////////////////////////////////////////////
                String espacio = "", cadenareversa = "";//creacion de nuevas variables
                int newindex = index + 24;//se aumenta 24 posiciones de : Cuenta/ CLABE Ordenante (aqui empieza) 
                string nback = "\n";
                while (espacio != " " && espacio != nback)
                {

                    //espacio es la variable que se va moviendo hasta encontrar un " " (espacio)
                    espacio = resultado[newindex].ToString();
                    //Console.WriteLine("espacio! : " + espacio);
                    newindex = newindex + 1; //aumento en uno para obtener el index del espacio (hasta que termine 00009987etc..)

                    Console.WriteLine("New index mio : " + newindex);
                }

                //al final new index tendra el index del espacio terminando el motivo pago


                for (int j = 0; j <= 9; j++)//se le modifico de 11 a 9 por el "\n" que lo toma como 2 no se por que 
                {
                    //del espacio voy recorriendo hacia atras y concatenando
                    buscacadenarev = ((resultado[newindex - j - 2]).ToString());
                    cadenareversa = buscacadenarev.ToString() + cadenareversa;
                }

                ////////////////////////////////////////////////


                for (int i = 18; i <= 28; i++)
                {//esta es para adelante PERO NO SALE BIEN , asi que se usa la de reversa
                    buscacadena = ((resultado[index + i]).ToString());
                    resultadocadena = resultadocadena + buscacadena.ToString();//Aqui esta cuenta retiro

                }
                //IMPRIME CUENTA
                //estos son las dos variables , la vieja y la nueva (reversa)
                Console.WriteLine("Como estaba: " + resultadocadena + " mi cadena rev: " + cadenareversa);
                Conection con = new Conection();
                //en el where cambi resultadocadena POR cadenareversa (la nueva)
                resultado = con.conectar("Select CodEmpresa from CuentasAcorde where Cuenta='" + cadenareversa + "'");// aqui ya es codempresa
                Console.WriteLine(resultado);

                //code aldo-------------------------------------------------------------------------------------

                //el mismo cambio de variables como en el where :
                CadenaCortada = cadenareversa.Substring(5, 5); // corta cuenta para buscaretiro

                //fin code aldo----------------------------------------------------------------------------------

                //CortaCuenta(resultadocadena); //ya no es necesario
            }



            return resultado + "_" + CadenaCortada; //ya tenemos codeigo de empresa + cuenta retiro (5 digitos)

        }






        public String buscaretiroCIE(int hoja, String pathPDF)
        {
            string resultado;
            string buscacadena = "";
            string resultadocadena = "";
            string CadenaCortada = "";
            string buscacadenarev = "";
            // IMPRIME EL TEXTO DEL PDF Console.WriteLine(ExtractTextFromPdf("C:/sample.pdf"));
            //ASIGNA EL TEXTO DEL PDF A UNA STRING
            resultado = ExtractTextFromPdf(hoja, pathPDF);//Regresa el texto ya sabe de que pagina!
            //BUSCA UNA CADENA DENTRO DEL TEXTO
            int index = resultado.IndexOf("Cuenta de retiro: ");
            Console.WriteLine(index);
            Console.WriteLine(resultado[index]);


            Console.WriteLine("Aqui si llega nuemro 3");
            //////////////////////////////////////////////////
            String espacio = "", cadenareversa = "";//creacion de nuevas variables
            int newindex = index + 18;//se aumenta 18 posiciones de : cuenta de retiro:(aqui empieza) 

            while (espacio != " ")
            {

                //espacio es la variable que se va moviendo hasta encontrar un " " (espacio)
                espacio = resultado[newindex].ToString();
                //Console.WriteLine("espacio! : " + espacio);
                newindex = newindex + 1; //aumento en uno para obtener el index del espacio (hasta que termine 00009987etc..)

                Console.WriteLine("New index mio : " + newindex);
            }

            //al final new index tendra el index del espacio terminando el motivo pago


            for (int j = 0; j <= 11; j++)
            {
                //del espacio voy recorriendo hacia atras y concatenando
                buscacadenarev = ((resultado[newindex - j]).ToString());
                cadenareversa = buscacadenarev.ToString() + cadenareversa;
            }

            ////////////////////////////////////////////////




            // TRAE FECHA DE APLICACION
            for (int i = 26; i <= 37; i++)
            {
                buscacadena = ((resultado[index + i]).ToString());
                resultadocadena = resultadocadena + buscacadena.ToString();//Aqui esta cuenta retiro

            }
            //IMPRIME CUENTA

            Console.WriteLine("anterior : "+resultadocadena+"Nuevo mio : "+cadenareversa);
            Console.WriteLine("aqui si llega 4 : aqui manda a sql la NUEVA MIA");
            Conection con = new Conection();
            resultado = con.conectar("Select CodEmpresa from CuentasAcorde where Cuenta='" + cadenareversa+"'");// aqui ya es codempresa
            Console.WriteLine(resultado);

            //code aldo-------------------------------------------------------------------------------------

            CadenaCortada = cadenareversa.Substring(5, 5); // corta cuenta para buscaretiro

            //fin code aldo----------------------------------------------------------------------------------

            //CortaCuenta(resultadocadena); //ya no es necesario


            return resultado + "_" + CadenaCortada; //ya tenemos codeigo de empresa + cuenta retiro (5 digitos)

        }

        public  String CortaCuenta(String CodEmpre1)
        {
            CodEmpre1 = CodEmpre1.Substring(5, 5); // corta cuenta para buscaretiro
            return CodEmpre1;
        }

        //METODO PARA SACAR EL TEXTO DE PDF
        public  string ExtractTextFromPdf(int hoja,string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                int hojas = reader.NumberOfPages;//leer numerp de paginas?
                Console.WriteLine("numero de paginas: "+hojas);

                StringBuilder text = new StringBuilder();
                int i = hoja;//ya sabe que pagina va 
                //    for (int i = 1; i <= reader.NumberOfPages; i++)
                // {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                // }

                return text.ToString();

            }
        }


    }
}
