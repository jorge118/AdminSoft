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
    class PropietarioController
    {
        MySqlConnection databaseConnection =
            new MySqlConnection("server=127.0.0.1;port=3306;Uid=root;pwd=root;database=nextadmindb");
        public void registrarPropietario(Propietario pro)
        {
            string sentencia;
            sentencia = "Insert into propietarios(idpropietario,tipoPropiedad,costo) values(" +
                "'" + pro.IdPropietario + "','" + pro.TipoPropiedad + "','" +pro.Costo +"')";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);


            try
            {
                databaseConnection.Open();



                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Propietario dado de alta");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

                MessageBox.Show("Error:" + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }



        public void modificarPropietario(Propietario pro)
        {
            string sentencia;
            sentencia = "update propietarios set tipoPropiedad = '" + pro.TipoPropiedad + "','" +pro.Costo+ 
                "   where idpropietario='" + pro.IdPropietario +   "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Propietario modificado");
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

        public void EliminarPropietario(Propietario pro)
        {
            string sentencia;
            sentencia = "delete from  propietario  where idpropietario='" + pro.IdPropietario + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sentencia, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Dato eliminado");
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
