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
    public class Conection
    {
        //SqlConnection conexion = new SqlConnection("data source = 10.0.0.106; initial catalog = PRECIOGAS; user id = SA; password = &90#1");
        SqlConnection conexion = new SqlConnection("data source = 192.168.2.209; initial catalog = PRECIOGAS; user id = SA; password = SAPB1Admin");

        public String conectar(String Consulta)
        {
            
            String resultado = "";
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            cmd.CommandText = Consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //Console.WriteLine("{0}", reader[0]);
                    resultado = reader[0].ToString();
                }
                reader.NextResult();
            }
            else
            {
                Console.WriteLine("no jala lucas");
                MessageBox.Show("Problema detectado en generación de nombre, contacte a Sistemas");
            }
            reader.Close();
            conexion.Close();
            Console.WriteLine("Se cerró la conexión.");
            Console.ReadLine();
            //Console.ReadKey();
            return resultado;
        }

    }
}