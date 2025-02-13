﻿using AdminSoftNext.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Controlador
{
    class CallesController
    {
        MySqlConnection databaseConnection =
            new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb");
        public void registrarColono(Calles cal)
        {
            string sentencia;
            sentencia = "Insert into calles(idcalles,nombre) values(" +
                "'" + cal.Idcalles + "','" + cal.Nombre +  "')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();
                
               

                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Calle dado de alta");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                
                MessageBox.Show("Error:" + ex.StackTrace);

            }
            finally
            {
                databaseConnection.Close();
            }
        }



        public void modificarColono(Calles cal)
        {
            string sentencia;
            sentencia = "update calles set nombre = '" + cal.Nombre +  "' where idcalles='" + cal.Idcalles + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Calle modificado");
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

        public void EliminarCalle(Calles cal)
        {
            string sentencia;
            sentencia = "delete from  calles  where idcalles ='" + cal.Idcalles + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Calle eliminada");
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
