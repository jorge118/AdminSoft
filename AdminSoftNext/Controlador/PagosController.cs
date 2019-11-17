using AdminSoftNext.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Controlador
{
    class PagosController
    {
        MySqlCommand cmd ;


        MySqlConnection databaseConnection = 
            new MySqlConnection("server=127.0.0.1;port=3306;database=nextadmindb;Uid=root;pwd=root;");

        public void insertarPago(Pagos pg, DetallePagos dp)
        {
            string sql;
            sql = "CALL insertarPago(?,?,?,?,?,?,?,?,?,?)";
            cmd = new MySqlCommand();
            


            try
            {
                cmd.Connection = databaseConnection;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "INS_PAGO";
                databaseConnection.Open();
                MySqlParameter[] pms = new MySqlParameter[8];

                //pms[0] = new MySqlParameter("nidDetalle", MySqlDbType.Int32);
                //pms[0].Value = dp.IdDetallePago;

                //pms[1] = new MySqlParameter("nidPago", MySqlDbType.Int32);
                //pms[1].Value = pg.IdPago;

                pms[0] = new MySqlParameter("nidconcepto", MySqlDbType.Int32);
                pms[0].Value = dp.IdConcepto;

                pms[1] = new MySqlParameter("nidcolono", MySqlDbType.Int32);
                pms[1].Value = pg.IdColono;

                pms[2] = new MySqlParameter("nidmes", MySqlDbType.Int32);
                pms[2].Value = dp.Idmes;


                pms[3] = new MySqlParameter("ncantidad", MySqlDbType.Int32);
                pms[3].Value = dp.Cantidad;

                pms[4] = new MySqlParameter("ncostoUn", MySqlDbType.Double);
                pms[4].Value = dp.CostoUnitario;

                pms[5] = new MySqlParameter("ncostoTotal", MySqlDbType.Double);
                pms[5].Value = dp.CostoUnitario;

                pms[6] = new MySqlParameter("nTotal", MySqlDbType.Double);
                pms[6].Value = dp.Total1;

                pms[7] = new MySqlParameter("nidtipo", MySqlDbType.Int32);
                pms[7].Value = dp.Idtipo;


                cmd.Parameters.AddRange(pms);
                cmd.ExecuteNonQuery();
                //MySqlDataReader myReader = cmd.ExecuteReader();
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Pago Realizado Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el pago");
                }
                cmd.CommandTimeout = 60;
                
               
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message +"    "+  ex.StackTrace);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();
            }
        }


    }
}
