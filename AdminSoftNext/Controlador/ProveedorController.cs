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
    class ProveedorController
    {
        
        Proveeduria proveeduria = new Proveeduria();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection databaseConnection =
            new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root");
        public void altaProveedor(Proveedor pro)
        {
            string query;
            query = "Insert into proveedores(idProveedor,nombreProveedor,razonSocial,rfc,tipoProve,direccion,telFijo,celular,email,estatus) values(" +
                "'"+ pro.IdProveedor +"','"+ pro.NombreProveedor +"','"+ pro.RazonSocial +"','"+ pro.Rfc +"','"+ pro.TipodeProveeduria +"','"+ pro.Direccion +"'," +
                "'"+ pro.TelefonoFijo +"','"+ pro.Celular +"','"+pro.Email+"','"+pro.Estatus+"')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Proveedor dado de alta");
                databaseConnection.Close();
            }
            catch(Exception ex)

            {
                MessageBox.Show("Hubo un error:" +ex.Message + "," + ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }


        public void modificarProveedor(Proveedor pro)
        {
            string query;
            query = "update proveedores set " +
            "nombreProveedor ='" + pro.NombreProveedor + "', razonSocial ='" + pro.RazonSocial +
                "', rfc ='" + pro.Rfc + "', tipoProve = '" + pro.TipodeProveeduria + "', direccion ='" + pro.Direccion + "" +
                "', telFijo = '" + pro.TelefonoFijo + "', celular = '" + pro.Celular + "',email ='" + pro.Email + "',estatus ='" + pro.Estatus + "'where idProveedor = '"+pro.IdProveedor+"' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                commandDatabase.CommandTimeout = 60;

                MessageBox.Show("Proveedor modificado");
                databaseConnection.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Hubo un error:" + ex.Message+"," + ex.StackTrace
                    + "," + ex.HResult);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void eliminarProveedor(Proveedor pro)
        {
            string query;
            query = "delete from  proveedores where idProveedor = '" + pro.IdProveedor + "' ";
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
