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
    class TipoConceptoController
    {
        MySqlConnection databaseConnection =
            new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb");
        public void registrarTipo(TipoCuotas tc)
        {
            string sentencia;
            sentencia = "Insert into tipoConcepto(idConcepto,concepto,precio)" +
                " values( '" + tc.IdConcepto + "', '" + tc.Concepto +"','"+tc.Costo+ "')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();


                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tipo de Couta dado de alta");
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

        public void modificarTipo(TipoCuotas tc)
        {
            string sentencia;
            sentencia = "update tipoConcepto set concepto = '"+ tc.Concepto+"' , precio = '" + tc.Costo+"' where idConcepto = '" + tc.IdConcepto+ "' ";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tipo de Couta modificado");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace );
                
                MessageBox.Show( ex.TargetSite + "\n" + ex.Source);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void EliminarTipos(TipoCuotas tc)
        {
            string sentencia;
            sentencia = "delete from tipoConceptos  where idConcepto ='" + tc.IdConcepto + "'";
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
