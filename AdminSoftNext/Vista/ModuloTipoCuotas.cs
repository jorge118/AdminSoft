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
    public partial class ModuloTipoCuotas : Form
    {
        Random rd = new Random();
        int idC = 0;
        TipoCuotas tc = new TipoCuotas();
        TipoConceptoController tcc = new TipoConceptoController();
        int fila = 0;
        public ModuloTipoCuotas()
        {
            InitializeComponent();
        }

        private void ModuloTipoCuotas_Load(object sender, EventArgs e)
        {
            try
            {
                
                lbId.Visible = false;
                MostrarDatos();
                this.dataGridView1.Columns["idConcepto"].Visible = false;
            }
            catch
            {

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                idC = rd.Next(1, 9000);
                lbId.Text = idC.ToString();
                this.tc.IdConcepto = Convert.ToInt32(lbId.Text);
                this.tc.Concepto = txtConcepto.Text;
                this.tc.Costo = Convert.ToDouble(txtPrecio.Text);
                this.tcc.registrarTipo(tc);
                limpiarTexto();
                MostrarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un problema: " + "  " + ex.Message+ " \n " + ex.StackTrace);
            }


        }

        public void MostrarDatos()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select * from tipoConcepto;";

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

        public void limpiarTexto()
        {
            this.txtConcepto.Text = "";
            this.txtPrecio.Text = "";
            idC = rd.Next(1, 9000);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTexto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            //idC =Convert.ToInt32 (dataGridView1.Rows[fila].Cells[0].Value.ToString());
            try
            {
                lbId.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                txtConcepto.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                txtPrecio.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            }
            catch
            {

            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lbId.Text == "0" || lbId.Text == null) {
                }
                else
                {
                    //lbId.Text = idC.ToString();
                    this.tc.IdConcepto = Convert.ToInt32(lbId.Text);
                    this.tc.Concepto = txtConcepto.Text;
                    this.tc.Costo = Convert.ToDouble(txtPrecio.Text);
                    this.tcc.modificarTipo(tc);
                    limpiarTexto();
                    MostrarDatos();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema: " + "  " + ex.Message + " \n " + ex.StackTrace
                    + " \n " );
               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(fila == null)
                {

                }
                else
                {
                    DialogResult opcion;
                    this.tc.IdConcepto = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    opcion = MessageBox.Show(
                        "Deseas eliminar a este Tipo de Pago",
                        "Confirmacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );
                    if (opcion == DialogResult.Yes)
                    {
                        lbId.Text = idC.ToString();
                        this.tc.IdConcepto = Convert.ToInt32(lbId.Text);
                        this.tc.Concepto = txtConcepto.Text;
                        this.tc.Costo = Convert.ToDouble(txtPrecio.Text);
                        this.tcc.EliminarTipos(tc);
                        limpiarTexto();
                        MostrarDatos();

                    }
                    else
                    {
                        //Close();
                    }
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema: " + "  " + ex.Message + " \n " + ex.StackTrace);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
