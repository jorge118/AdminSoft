using AdminSoftNext.Beans;
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
    public partial class ModuloPagos : Form
    {
        public ModuloPagos()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable();
        ColonoBeans colbn = new ColonoBeans();
        Colono colono = new Colono();
        ColonoController colc = new ColonoController();
        int fila = 0;
        string nombre = "";
        string direccionC = "";


        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades from v_col where estatus = 1;";

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
        public void cargarDatos()
        {

            this.colono.Idcolono = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
            this.colono.Nombre = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);
            this.colono.ApPaterno = Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value);
            this.colono.ApMaterno = Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value);
            this.colono.Telefono = Convert.ToString(dataGridView1.Rows[fila].Cells[8].Value);
            this.colono.Direccion = Convert.ToInt32(dataGridView1.Rows[fila].Cells[1].Value);
            this.colono.Numero = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
            this.colono.Email = Convert.ToString(dataGridView1.Rows[fila].Cells[7].Value);
            this.colono.Propietario = Convert.ToInt32(dataGridView1.Rows[fila].Cells[6].Value.ToString());

        }

        public void llenarCombo()
        {
            comboBox1.Items.Add("Nombre");
            comboBox1.Items.Add("Apellido Paterno");
            comboBox1.Items.Add("Apellido Materno");
            comboBox1.Items.Add("Direccion");
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

                string query = "select * from v_col where idcolono like('" + textBox1.Text + "%')";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandType = CommandType.Text;
                if (comboBox1.SelectedItem.ToString() == "Nombre")
                {
                    cmd.CommandText = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades from v_col where nombre like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Apellido Paterno")
                {
                    cmd.CommandText = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades from v_col where apPaternolike('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Apellido Paterno")
                {
                    cmd.CommandText = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades from v_col where apMaterno like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Direccion")
                {
                    cmd.CommandText = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,numeroPropiedades from v_col where Direccion like('" + textBox1.Text + "%')";

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

        private void ModuloPagos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            llenarCombo();
            try
            {
                this.dataGridView1.Columns["idcolono"].Visible = false;
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioPagos fp = new FormularioPagos();
                nombre = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value) + " " + Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value) + " " +
                    Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value);
                direccionC = Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value) + " " + Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
                fp.idcolono = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                fp.nom = nombre;
                fp.dir = direccionC;
                fp.ShowDialog();

            }
            catch
            {

            }
        }

       
    }
}
