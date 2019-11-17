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
    class SaldosController
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection databaseConnection =
             new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb");
        public void insertarSaldo(Saldos sd)
        {
            string sentencia;
            sentencia = "insert into saldos values ('"+sd.IdSaldo+"' , " +
                "'"+sd.SaldoInicial+"','"+sd.Idcolono+"' ,'"  +sd.Comentarios+" ')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();
                

                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Saldo dado de alta");
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
                databaseConnection.Close();
            }
        }


        public void actualizarSaldo(Saldos sd)
        {
            string sentencia;
            sentencia = "update saldos set saldoInicial = '"+sd.SaldoInicial+"' ," +
                "set comentarios = '"+sd.Comentarios+"' ";
            
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();


                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Saldo modificado");
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
                databaseConnection.Close();
            }
        }
    }
}
