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
    public partial class ModuloTags : Form
    {
        DataTable tabla = new DataTable();
        FormularioTags fTags;
        Tags tgs = new Tags();
        TagController tgC = new TagController();
        int fila;
        public ModuloTags()
        {
            InitializeComponent();
        }

        private void ModuloTags_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            llenarCombo();
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;

            try
            {
                this.dataGridView1.Columns["idTag"].Visible = false;

            }
            catch
            {

            }
        }


        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "SELECT * FROM tags";

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
            fTags = new FormularioTags();
            fTags.cont = 1;
            fTags.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            if(fila == null)
            {
                btnBorrar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                fTags = new FormularioTags();
                if (fTags.idTags == null || fila == null)
                {
                    MessageBox.Show("Fila sin datos");
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                }
                else
                {
                    fTags.idTags = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    fTags.numTag = Convert.ToInt32(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                    fTags.numSitio2 = Convert.ToInt32(dataGridView1.Rows[fila].Cells[2].Value.ToString());
                    fTags.tipVehiculo = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                    fTags.placas = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                    fTags.color = dataGridView1.Rows[fila].Cells[5].Value.ToString();
                    fTags.obser = dataGridView1.Rows[fila].Cells[7].Value.ToString();
                    fTags.cont = 2;
                    fTags.ShowDialog();
                }
            }
            catch
            {

            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(fila == null)
                {

                }
                else
                {
                    this.tgs.IdTag = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    tgC.eliminarTag(tgs);
                }
            }
            catch
            {

            }
        }

        public void llenarCombo()
        {
            comboBox1.Items.Add("Direccion");
            comboBox1.Items.Add("Tipo de Vehiculo");
            comboBox1.Items.Add("Color");
            comboBox1.Items.Add("Placas");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL


            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();

                string query = "select * from colono where idcolono like('" + textBox1.Text + "%')";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandType = CommandType.Text;
                if (comboBox1.SelectedItem.ToString() == "Tipo de Vehiculo")
                {
                    cmd.CommandText = "SELECT * FROM tags where tipoVehiculo like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Color")
                {
                    cmd.CommandText = "SELECT * FROM tags where color like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Placas")
                {
                    cmd.CommandText = "select * from tags where numPlacas like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Direccion")
                {
                    cmd.CommandText = "select * from tags where colono like('" + textBox1.Text + "%')";
                }
                //cmd.CommandText = "select * from colono where idcolono like('" + textBox1.Text + "%') or " +
                //    "nombre like('"+textBox1.Text+"%')" +
                //    "or apPaterno like('" + textBox1.Text + "%')" +
                //    "or apMaterno like('" + textBox1.Text + "%')" +
                //    "or telefono like('" + textBox1.Text + "%')" +
                //    "or direccion like('" + textBox1.Text + "%')" +
                //    "or propietario like('" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                databaseConnection.Close();
            }
            catch
            {

            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }
    }
}
