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
    public partial class ModuloProveedor : Form
    {
        DataTable tabla = new DataTable();
        int fila;
        public ModuloProveedor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "SELECT * FROM proveedores order by estatus";

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

        public void llenarCombo()
        {
            comboBox1.Items.Add("Nombre");
            comboBox1.Items.Add("RFC");
            comboBox1.Items.Add("Razon Social");
            comboBox1.Items.Add("Direccion");
            comboBox1.Items.Add("Telefono");
            comboBox1.Items.Add("Tipo de Proveeduria");
        }

        private void ModuloProveedor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            llenarCombo();
            try
            {
                this.dataGridView1.Columns["idProveedor"].Visible = false;
            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioProveedor frp = new FormularioProveedor();
            frp.cont = 1;
            frp.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioProveedor prov = new FormularioProveedor();
                prov.idProve = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                prov.nombrePro = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value.ToString());
                prov.rSocial = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value.ToString());
                prov.rfc = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                prov.tipo = Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value.ToString());
                prov.dir = Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value.ToString());
                prov.tel = Convert.ToString(dataGridView1.Rows[fila].Cells[6].Value.ToString());
                prov.cel = Convert.ToString(dataGridView1.Rows[fila].Cells[7].Value.ToString());
                prov.email = Convert.ToString(dataGridView1.Rows[fila].Cells[8].Value.ToString());
                prov.cont = 2;
                if(prov.idProve == 0 || prov.idProve == null){
                    MessageBox.Show("Seleccione una fila con datos");
                }
                else
                {
                    prov.Show();
                }
                
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            int idL = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            try
            {
                
            }
            catch
            {

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL


            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();

                string query = "select * from proveedores where idcolono like('" + textBox1.Text + "%')";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandType = CommandType.Text;
                if (comboBox1.SelectedItem.ToString() == "Nombre")
                {
                    cmd.CommandText = "select * from proveedores where nombreProveedor like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "RFC")
                {
                    cmd.CommandText = "select * from proveedores where rfc like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Razon Social")
                {
                    cmd.CommandText = "select * from proveedores where razonSocial like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Direccion")
                {
                    cmd.CommandText = "select * from proveedores where direccion like('" + textBox1.Text + "%')";
                }
                if(comboBox1.SelectedItem.ToString() == "Tipo de Proveeduria")
                {
                    cmd.CommandText = "select * from proveedores where tipoProve like('" + textBox1.Text + "%')";
                }
                if(comboBox1.SelectedItem.ToString() == "Telefono")
                {
                    cmd.CommandText = "select * from proveedores where telefono like('" + textBox1.Text + "%')";
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
    }
}
