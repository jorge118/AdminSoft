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
    public partial class ModuloSaldos : Form
    {
        int fila = 0;
        
        public ModuloSaldos()
        {
            InitializeComponent();
        }

        private void ModuloSaldos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            try
            {
                this.dataGridView1.Columns["idcolono"].Visible = false;
                this.dataGridView1.Columns["idsaldo"].Visible = false;
            }
            catch
            {

            }
        }

        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select * from v_Saldos;";

            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            //tabla.Rows.Clear();
            DataSet ds = new DataSet();

            try
            {
                databaseConnection.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, connectionString);
                MySqlCommandBuilder cms = new MySqlCommandBuilder(adaptador);
                adaptador.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.Refresh();
                //this.dataGridView1.Columns["idcolono"].Visible = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioSaldos fs = new FormularioSaldos();
                //fs.idColono = Convert.ToInt32()
                fs.opc = 1;
                fs.ShowDialog();
            }
            catch
            {
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioSaldos fs = new FormularioSaldos();
                fs.idColono = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                fs.idSal = Convert.ToInt32(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                fs.opc = 2;
                fs.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
