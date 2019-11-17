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
    class TiposPagoController
    {

        MySqlConnection databaseConnection =
             new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb;");

        public void registrarTipo(TipoPagos tp)
        {
            string sentencia;
            sentencia = "Insert into tipoPagos(idTipo,tipo)" +
                " values( '"+tp.IdPago+"', '"+ tp.Tipo+"')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();
                

                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tipo de Pago dado de alta");
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

        public void modificarTipo(TipoPagos tp)
        {
            string sentencia;
            sentencia = "update tipoPagos set tipo = '" + tp.Tipo  + "' where idTipo='" + tp.IdPago + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tipo de Pago modificado");
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

        public void EliminarTipos(TipoPagos tp)
        {
            string sentencia;
            sentencia = "delete from tipoPagos  where idTipo ='" + tp.IdPago + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tipo de Pago eliminado");
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
