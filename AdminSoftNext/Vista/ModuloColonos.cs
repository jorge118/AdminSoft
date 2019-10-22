using AdminSoftNext.Beans;
using AdminSoftNext.Controlador;
using AdminSoftNext.Modelo;
using AdminSoftNext.mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Vista
{
    public partial class ModuloColonos : Form
    {
        modelo mod = new modelo();
        DataTable tabla = new DataTable();
        ColonoBeans colbn = new ColonoBeans();
        Colono colono = new Colono();
        
        ColonoController colc = new ColonoController();
        int fila = 0;
        public int refrescar;
        int idInicial;
        public Thread hilo;
        public ModuloColonos()
        {
            InitializeComponent();
        }

        private void ModuloColonos_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.Refresh();
            dataGridView1.DataSource = tabla;
            
            button3.Enabled = false;
            button2.Enabled = false;
            llenarCombo();
            
            try
            {
                MostrarDatos();
                this.dataGridView1.Columns["idcolono"].Visible = false;
                
                
                // ThreadStart delegado = new ThreadStart(MostrarDatos);


                //idInicial = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());

                if (fila == null)
                {
                    button3.Enabled = false;
                    button2.Enabled = false;
                }
                

                
            }
            catch
            {

            }

        }



        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select idcolono,Direccion,numero,nombre, apPaterno,apMaterno,tipoPropiedad,email,telefono,numeroPropiedades from vista_colono;";

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
                //dataGridView1.Refresh();
                //this.dataGridView1.Columns["idcolono"].Visible = false;
                databaseConnection.Close();
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                databaseConnection.Close();
            }
            finally
            {
                databaseConnection.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioColonos fr = new FormularioColonos();
                fr.contCol = 1;
                fr.Show();
            }
            catch
            {

            }
           
            
           
            button3.Enabled = false;
            button2.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //cargarDatos();
                FormularioColonos fr = new FormularioColonos();
                //FormularioColonos fr1 = new FormularioColonos();
                fr.idCol = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                fr.nom = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);
                fr.apepa = Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value);
                fr.apema = Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value);
                fr.tel = Convert.ToString(dataGridView1.Rows[fila].Cells[8].Value);
                //fr.dir = Convert.ToInt32(dataGridView1.Rows[fila].Cells[1].Value.ToString());

                fr.numC = Convert.ToInt32(dataGridView1.Rows[fila].Cells[2].Value.ToString());
                fr.email = Convert.ToString(dataGridView1.Rows[fila].Cells[7].Value);
                //fr.prop = Convert.ToInt32(dataGridView1.Rows[fila].Cells[6].Value.ToString());
                fr.nPro = Convert.ToInt32(dataGridView1.Rows[fila].Cells[9].Value.ToString());
                fr.contCol = 2;
                if (fr.idCol == 0||fr.idCol == null)
                {
                    MessageBox.Show("Seleccione una fila con datos");
                }
                else
                {
                    
                    fr.ShowDialog();

                }





            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+  ex.StackTrace);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            button1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            if (fila == null)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                //button1.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button2.Enabled = true;
                
            }
        }

        public void llenarCombo()
        {
            comboBox1.Items.Add("Nombre");
            comboBox1.Items.Add("Apellido Paterno");
            comboBox1.Items.Add("Apellido Materno");
            comboBox1.Items.Add("Direccion");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == null)
                {
                    button3.Enabled = false;
                    button2.Enabled = false;
                    
                   
                }
                else
                {
                    DialogResult opcion;
                    this.colono.Idcolono = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    opcion = MessageBox.Show(
                        "Deseas eliminar a este Colono",
                        "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );
                    if (opcion == DialogResult.Yes)
                    {
                        colc.Eliminar(colono);
                        MostrarDatos();
                        button3.Enabled = false;
                        button2.Enabled = false;

                    }
                    else
                    {
                        //Close();
                    }
                }
                
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

                string query = "select * from colono where idcolono like('" + textBox1.Text + "%')";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandType = CommandType.Text;
                if(comboBox1.SelectedItem.ToString() == "Nombre")
                {
                    cmd.CommandText = "select idcolono,direccion,numero,nombre,apPaterno,apMaterno,propietario,email,telefono,numeroPropiedades from colono where nombre like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Apellido Paterno")
                {
                    cmd.CommandText = "select idcolono,direccion,numero,nombre,apPaterno,apMaterno,propietario,email,telefono,numeroPropiedades from colono where apPaternolike('" + textBox1.Text + "%')";
                }
                if(comboBox1.SelectedItem.ToString() == "Apellido Paterno")
                {
                    cmd.CommandText = "select idcolono,direccion,numero,nombre,apPaterno,apMaterno,propietario,email,telefono,numeroPropiedades from colono where apMaterno like('" + textBox1.Text + "%')";
                }
                if (comboBox1.SelectedItem.ToString() == "Direccion")
                {
                    cmd.CommandText = "select idcolono,direccion,numero,nombre,apPaterno,apMaterno,propietario,email,telefono,numeroPropiedades from colono where direccion like('" + textBox1.Text + "%')";
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

       

        private void ModuloColonos_SizeChanged(object sender, EventArgs e)
        {
            //dataGridView1.Size = new Size(967, 197);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
        }
    }
}
