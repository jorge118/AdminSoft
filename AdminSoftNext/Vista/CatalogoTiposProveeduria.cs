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
    public partial class CatalogoTiposProveeduria : Form
    {
        DataTable tabla = new DataTable();
        Proveeduria tpr = new Proveeduria();
        ProveeduriaController  prC= new ProveeduriaController();
        Random rd = new Random();
        int idTipo;
        int fila;
        public CatalogoTiposProveeduria()
        {
            InitializeComponent();
        }

        private void CatalogoTiposProveeduria_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            textBox1.Visible = false;
            idTipo = rd.Next(1001, 9999);
            textBox1.Text = idTipo.ToString();
        }

        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "SELECT * FROM tipoProveedurias";

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.tpr.IdProveeduria = Convert.ToInt32(textBox1.Text);
            this.tpr.TipoProveeduria = textBox2.Text;
            prC.altatipoProveeduria(tpr);
            textBox1.Text = "";
            textBox2.Text = "";
            idTipo = rd.Next(1001, 9999);
            textBox1.Text = idTipo.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;

            try
            {
                int idTipoProvee = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                string tipoProve = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value);
                textBox1.Text = idTipoProvee.ToString();
                textBox2.Text = tipoProve.ToString();
                if(idTipoProvee == 0)
                {
                    MessageBox.Show("Fila incorrecta o no contiene datos");
                }
            }
            catch
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                this.tpr.IdProveeduria = Convert.ToInt32(textBox1.Text);
                this.tpr.TipoProveeduria = textBox2.Text;
                prC.modificartipoProveeduria(tpr);
                textBox1.Text = "";
                textBox2.Text = "";
                idTipo = rd.Next(1001, 9999);
                textBox1.Text = idTipo.ToString();
            }
            catch
            {
                MessageBox.Show("Error intenta mas tarde");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tpr.IdProveeduria = Convert.ToInt32(textBox1.Text);
                this.tpr.TipoProveeduria = textBox2.Text;
                prC.eliminartipoProveeduria(tpr);
                textBox1.Text = "";
                textBox2.Text = "";
                idTipo = rd.Next(1001, 9999);
                textBox1.Text = idTipo.ToString();
            }
            catch
            {

            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
