using AdminSoftNext.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Controlador
{
    class ProveeduriaController
    {
        Proveeduria prove = new Proveeduria();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection databaseConnection =
            new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb");
        public void altatipoProveeduria(Proveeduria prove)
        {
            string query;
            query = "Insert into tipoProveedurias values(" +
                "'" + prove.IdProveeduria + "','" + prove.TipoProveeduria + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Proveedoria dado de alta");
                databaseConnection.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Hubo un error:" + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }


        public void modificartipoProveeduria(Proveeduria prove)
        {
            string query;
            query = "update tipoProveedurias set " +
            "tipoProveeduria='" + prove.TipoProveeduria + "' where idtipoProveeduria = '" + prove.IdProveeduria + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Proveedoria modificada");
                databaseConnection.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Hubo un error:" + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void eliminartipoProveeduria(Proveeduria prove)
        {
            string query;
            query = "delete from tipoProveedurias where idtipoProveeduria = '" + prove.IdProveeduria + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Proveedor eliminado");
                databaseConnection.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Hubo un error:" + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }


    }
}
