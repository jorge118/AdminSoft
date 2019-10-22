using AdminSoftNext.Controlador;
using AdminSoftNext.Modelo;
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
    public partial class FormularioTiposPago : Form
    {
        DataTable tabla = new DataTable();
        Random rd = new Random();
        
        int id = 0;
        
        int fila = 0;
        TipoPagos tp = new TipoPagos();
        TiposPagoController tpC = new TiposPagoController();
        public FormularioTiposPago()
        {
            InitializeComponent();
        }

        private void FormularioTiposPago_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtidPago.Visible = false;
            id = rd.Next(100,1000);
            txtidPago.Text = id.ToString();
            try
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                MostrarDatos();
                this.dataGridView1.Columns["idTipo"].Visible = false;
            }
            catch
            {

            }
        }


        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "SELECT * FROM tipoPagos";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;

            
            try
            {
                if (fila == null)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
                else
                {
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    int idPagos = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    string tipos = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                    txtidPago.Text = idPagos.ToString();
                    txtPago.Text = tipos.ToString();

                }

            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.tp.IdPago = Convert.ToInt32(txtidPago.Text);
            this.tp.Tipo = txtPago.Text;
            tpC.registrarTipo(tp);
            MostrarDatos();
            txtidPago.Text = "";
            txtPago.Text = "";
            id = rd.Next(100, 1000);
            txtidPago.Text = id.ToString();
            MostrarDatos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.tp.IdPago = Convert.ToInt32(txtidPago.Text);
            this.tp.Tipo = txtPago.Text;
            tpC.modificarTipo(tp);
            txtPago.Text = "";
            txtidPago.Text = "";
            id = rd.Next(100, 1000);
            txtidPago.Text = id.ToString();
            MostrarDatos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.tp.IdPago = Convert.ToInt32(txtidPago.Text);
            this.tp.Tipo = txtPago.Text;
            tpC.EliminarTipos(tp);
            txtPago.Text = "";
            txtidPago.Text = "";
            id = rd.Next(100, 1000);
            txtidPago.Text = id.ToString();
            MostrarDatos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
