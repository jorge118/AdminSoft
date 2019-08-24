using AdminSoftNext.Modelo;
using AdminSoftNext.mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Controlador
{
    class ColonoController:modelo
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection databaseConnection = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root");
        public void registrarColono(Colono col)
        {
            string sentencia;
            sentencia = "Insert into colono(idcolono,nombre,apPaterno,apMaterno," +
                "telefono,direccion,numero,email,propietario,numeroPropiedades) values(" +
                "'" + col.Idcolono + "','" + col.Nombre + "','" + col.ApPaterno + "','" + col.ApMaterno + "'," +
                "'" + col.Telefono + "','" + col.Direccion + "','" + col.Numero + "','" + col.Email + "','" + col.Propietario + "'," +
                "'" + col.NumeroPropiedades + "')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();
                //string SQL;

                


                //SQL = "Insert into colono(idcolono,nombre,apPaterno,apMaterno," +
                //    "telefono,direccion,numero,email,propietario,numeroPropiedades) values(" +
                //    "@idcolono,@nombre,@apPaterno,@apMaterno," +
                //    "@telefono,@direccion,@numero,@email,@propietario,@numeroPropiedades)";
                //cmd.Connection = Conn;
                //cmd.CommandText = SQL;
                //cmd.Parameters.AddWithValue("@idcolono", col.Idcolono);
                //cmd.Parameters.AddWithValue("@nombre", col.Nombre);
                //cmd.Parameters.AddWithValue("@apPaterno", col.ApPaterno);
                //cmd.Parameters.AddWithValue("@apMaterno", col.ApMaterno);
                //cmd.Parameters.AddWithValue("@telefono", col.Telefono);
                //cmd.Parameters.AddWithValue("@direccion", col.Direccion);
                //cmd.Parameters.AddWithValue("@numero", col.Numero);
                //cmd.Parameters.AddWithValue("@email", col.Email);
                //cmd.Parameters.AddWithValue("@propietario", col.Propietario);
                //cmd.Parameters.AddWithValue("@numeroPropiedades", col.Propietario);
                //cmd.ExecuteNonQuery();
                
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Colono dado de alta");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                MessageBox.Show("Error:" + ex.Source);
                MessageBox.Show("Error:" + ex.StackTrace);

            }
            finally
            {
                //Conn.Close();
            }
        }

        public void modificarColono(Colono col)
        {
            string sentencia;
            sentencia = "update colono set nombre = '"+ col.Nombre+"', " +
                "  apPaterno = '"+col.ApPaterno+"' ,  apMaterno = '"+col.ApMaterno+"', " +
                "  telefono = '"+col.Telefono+"',  direccion = '"+col.Direccion+"', email = '" +col.Email+"'"  +
                ", numero = '"+col.Numero+"' ,  propietario = '"+col.Propietario+ "' ,numeroPropiedades= '" + col.NumeroPropiedades+ "' where idcolono ='"+ col.Idcolono+"'" ;
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Colono modificado");
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ "," + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void Eliminar(Colono col)
        {
            string sentencia;
            sentencia = "delete from colono  where idcolono ='" + col.Idcolono + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Colono eliminado");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "," + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}
