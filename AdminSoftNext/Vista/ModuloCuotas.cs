using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Vista
{
    public partial class ModuloCuotas : Form
    {
        DataTable tabla = new DataTable();
        DataGridViewRow row = new DataGridViewRow();
        int fila;
        int ind;
        public ModuloCuotas()
        {
            InitializeComponent();
        }

        private void ModuloCuotas_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarDatos();
                
                this.dataGridView1.Columns["idcolono"].Visible = false;
                this.dataGridView1.Columns["estatus"].Visible = false;
                //colorearFilas();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.StackTrace+ "/n"+ ex.Message );
            }
        }

        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades,estatus from v_col where estatus = 0;";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            tabla.Rows.Clear();
            DataSet ds = new DataSet();

            try
            {
                databaseConnection.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, connectionString);
                MySqlCommandBuilder cms = new MySqlCommandBuilder(adaptador);
                adaptador.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void colorearFilas()
        {


            try
            {
                //dataGridView1.Rows.Cast<DataGridViewRow>().
                //          ToList().
                //          ForEach(fila =>
                //          {
                //              if (fila.Cells["estatus"].Value.ToString() == "1")
                //              {
                //                  fila.DefaultCellStyle.BackColor = Color.LightGreen;
                //              }
                //              else
                //              {
                //                  fila.DefaultCellStyle.BackColor = Color.Tomato;
                //              }


                //          });
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[row.Index].Cells["estatus"].Value.ToString()) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.SeaGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Excepcion:" + ex.Message + "" +
                    "/n " + ex.StackTrace);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            ind = e.ColumnIndex;
        }
    }
}
