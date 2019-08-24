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
    class TagController
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection databaseConnection = 
            new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root");

        public void registrarTag(Tags tg)
        {
            string sentencia;
            sentencia = "Insert into tags(idTag,numTag,numSitio,tipoVehiculo," +
                "numPlacas,color,colono,observaciones) values(" +
                "'" + tg.IdTag + "','" + tg.NumTag + "','" + tg.NumSitio + "','" + tg.TipoVehiculo + "'," +
                "'" + tg.NumPlacas + "','" + tg.Color + "','" + tg.Colono + "','" + tg.Observaciones+  "')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tag dado de alta");
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error en:" + ex.StackTrace);
                databaseConnection.Close();
            }

        }

        public void modificarTag(Tags tg)
        {
            string sentencia;
            sentencia = "Update tags set numTag = '" + tg.NumTag + "', numSitio = '" + tg.NumSitio + "',tipoVehiculo ='" + tg.TipoVehiculo + "'," +
                "numPlacas ='" + tg.NumPlacas + "', color = '" + tg.Color + "',colono = '" + tg.Colono + "',observaciones='" + tg.Observaciones + "'where " +
                "idTag ='"+tg.IdTag+"'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tag modificado");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en:" + ex.StackTrace);
                databaseConnection.Close();
            }
        }

        public void eliminarTag(Tags tg)
        {
            string sentencia;
            sentencia = "Delete from tags where " +
                "idTag ='" + tg.IdTag + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Tag eliminado");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en:" + ex.StackTrace);
                databaseConnection.Close();
            }
        }
    }
}
