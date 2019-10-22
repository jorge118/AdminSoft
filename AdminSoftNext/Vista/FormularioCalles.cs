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
    public partial class FormularioCalles : Form
    {

        Calles cal = new Calles();
        CallesController calCont = new CallesController();
        Random rd = new Random();
        int id = 0;
        //int num = 0;
        DataTable tabla = new DataTable();
        int fila = 0;
        public FormularioCalles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
            calCont.registrarColono(cal);
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            
            id = rd.Next(111, 2000);
            
            textBox1.Text = id.ToString();
            MostrarDatos();
        }

        public void cargar()
        {
            this.cal.Idcalles = Convert.ToInt32(textBox1.Text);
            this.cal.Nombre = textBox2.Text;
            
        }

        private void FormularioCalles_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Visible = false;
            id = rd.Next(111, 2000);
            textBox1.Text = id.ToString();
            MostrarDatos();
            try
            {
                this.dataGridView1.Columns["idcalles"].Visible = false;
            }
            catch
            {

            }
            

        }


        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "SELECT * FROM calles";

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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            try
            {
                int idcal = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                string nombre = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                int idnumero = Convert.ToInt32(dataGridView1.Rows[fila].Cells[2].Value.ToString());

                textBox1.Text = idcal.ToString();
                textBox2.Text = nombre;
                
                if(idcal == null || idcal == 0)
                {
                    MessageBox.Show("No hay Datos en esa fila");
                }
            }
            catch
            {

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargar();
            calCont.modificarColono(cal);
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            
            id = rd.Next(111, 2000);
            textBox1.Text = id.ToString();
            MostrarDatos();

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            cargar();
            calCont.EliminarCalle(cal);
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            
            id = rd.Next(111, 2000);
            textBox1.Text = id.ToString();
            MostrarDatos();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL


            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();

                string query = "select * from calles where idcalles like('" + textBox4.Text + "%')";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from calles where idcalles like('" + textBox4.Text + "%') or " +
                    "idcalles like('" + textBox4.Text + "%')" +
                    "or nombre like('" + textBox4.Text + "%')";
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
