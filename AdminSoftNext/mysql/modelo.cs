using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AdminSoftNext.mysql
{
   
    class modelo
    {
         private MySqlConnection conn =
                new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root");
         public MySqlConnection Conn { get; set; }
        public static bool pruebaConexion(string cadenaConexion)
        {
            try
            {
                // MySqlConnection nuevaConexion = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=GaNxtLa512");
                MySqlConnection nuevaConexion = new MySqlConnection(cadenaConexion);
                nuevaConexion.Open();
                return true;
            }catch (MySqlException ){

             
                return false;

            }
        }
        public static List<string> leerArchivoTextodb()

        {
            //  string ruta = @"dbConexion.txt";
            string ruta = "C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\AdminSoftNext\\AdminSoftNext\\dbConexion.txt";
            string x = null;
            List<string> datos = new List<string>();

            try
            {
                using (StreamReader leer = new StreamReader(ruta))
                {
                    while (!leer.EndOfStream)
                    {
                        x = leer.ReadLine();
                        datos.Add(x);
                        //Console.WriteLine(item);
                    }

                    leer.Close();
                    
                }
            }
            catch
            {
                MessageBox.Show("ERROR AL LEER LA INFORMACION");
            }
            return datos;
        }


        public static MySqlConnection conexionBaseDatos()
        {

            string cadenaConexion = null;

            List<String> datosConexion = leerArchivoTextodb();

            //cadenaConexion = "server=" + datosConexion[0].ToString() + ";database="+ datosConexion[1].ToString() +";Uid=" + datosConexion[2].ToString() + ";pwd=" + datosConexion[3].ToString();
            cadenaConexion = "server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root";
            try
            {
                MySqlConnection nuevaConexion = new MySqlConnection(cadenaConexion);
                nuevaConexion.Open();
                return nuevaConexion;
            }
            catch (MySqlException)
            {


                return null;
                
            }
            
        }

        public static MySqlConnection abrirConexion()
        {

            string cadenaConexion = null;

            List<String> datosConexion = leerArchivoTextodb();

            //cadenaConexion = "server=" + datosConexion[0].ToString() + ";database=" + datosConexion[1].ToString() + ";Uid=" + datosConexion[2].ToString() + ";pwd=" + datosConexion[3].ToString();
            //"server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"
            cadenaConexion = "server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root";
            try
            {
                MySqlConnection nuevaConexion = new MySqlConnection(cadenaConexion);
                nuevaConexion.Open();
                return nuevaConexion;
            }
            catch (MySqlException)
            {


                return null;

            }
        }
        public static bool validarUsuarioYcontraseña(string usuario,string contraseña)
        {

            MySqlConnection nvConexion = abrirConexion();
            String nombre = "";
            String password = ""; 

            string MysqlConsulta = "SELECT usuario, contraseña FROM nextadmindb.usuarios where usuario ='" + usuario.ToString() + "' and contraseña = '" + contraseña.ToString() +"'";

            MySqlCommand consultaUsuario = new MySqlCommand(MysqlConsulta, nvConexion);
            MySqlDataReader nvReader = consultaUsuario.ExecuteReader();
            while (nvReader.Read())
            {

                nombre = nvReader["usuario"].ToString();
                password = nvReader["contraseña"].ToString();
            }

            nvConexion.Close();


            if(usuario == nombre && contraseña == password)

            {
                return true;

            }
            else
                 return false;

        }

        public static int consultaId(string tabla)
        {


            return 0;
        }
    }
}
