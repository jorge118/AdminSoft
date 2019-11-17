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
    public partial class FormularioPagos : Form
    {
        

        public int idcolono;
        Random rd = new Random();
        Random rd2 = new Random();
        public string nom;
        public string dir;
        int fila;
        public int cant = 1;
        int idDetalle = 0;
        int idPago = 0;
        double subtotal = 0;
        double total = 0;
        int mesn = DateTime.Now.Month;
        int idmes;
        int idcon;
        PagosController pc = new PagosController();
        Pagos pg = new Pagos();
        DetallePagos dp = new DetallePagos();

        public FormularioPagos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioPagos_Load(object sender, EventArgs e)
        {
            try
            {

                //DataGridViewComboBoxColumn combo =
                //    new DataGridViewComboBoxColumn();
                //tipoConcepto2(combo);
                //combo.Name = "Concepto";
                dataGridView1.Rows.Add();
                dataGridView1.AllowUserToAddRows = false;
                lbNombre.Text = nom.ToString();
                lbDireccion.Text = dir.ToString();
                lbSubTotal.Text = subtotal.ToString();
                lbTotal.Text = total.ToString();
                idPago = rd.Next(10, 999999);
                idDetalle = rd2.Next(100, 99999);
                mostrarTiposPago();
                
                tipoConcepto();
                mes();
                //dataGridView1.Columns.Add(combo);
                this.dataGridView1.Rows[0].Cells[0].Value = cant;
                //this.dataGridView1.Columns["Descripcion"].Visible = false;
                //this.dataGridView1.Rows[0].Cells[5].Value = combo;

            }
            catch
            {

            }
        }

        public void mostrarTiposPago()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idTipo, tipo from tipopagos";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comboBox1.ValueMember = "idTipo";
                comboBox1.DisplayMember = "tipo";
                comboBox1.DataSource = dt;

            }
        }

        public void tipoConcepto()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idConcepto, concepto,precio from tipoConcepto";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                dtDescripcion.ValueMember = "idConcepto";
            
                dtDescripcion.DisplayMember = "concepto";
                dtDescripcion.DataSource = dt;
                //this.dataGridView1.Rows[0].Cells[3].Value = dtDescripcion.;

            }
        }

        public void tipoConcepto2(DataGridViewComboBoxColumn combo2)
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idConcepto, concepto,precio from tipoConcepto";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                combo2.ValueMember = "idConcepto";
                //idcon = combo2.ValueMember.Length;
                combo2.DisplayMember = "concepto";
                combo2.DataSource = dt;
                //this.dataGridView1.Rows[0].Cells[3].Value = dtDescripcion.;

            }
        }

        public void mes()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idmes, mes from meses where idmes = '"+mesn+"' ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                dtMes.ValueMember = "idmes";
                dtMes.DisplayMember = "mes";
                dtMes.DataSource = dt;

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                pg.IdColono = idcolono;
                //pg.IdPago = idPago;

                dp.IdConcepto = idcon;
                dp.IdDetallePago = idDetalle;
                dp.Idmes = Convert.ToInt32(dtMes.ValueMember.Length);
                dp.Idtipo = Convert.ToInt32(comboBox1.SelectedValue);
                dp.Cantidad = cant;
                dp.CostoTotal = Convert.ToDouble(this.dataGridView1.Rows[fila].Cells[4].Value);
                dp.CostoUnitario = Convert.ToDouble(this.dataGridView1.Rows[fila].Cells[3].Value);
                //pg.Total = total;
                dp.Total1 = total;
                pc.insertarPago(pg, dp);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ex.StackTrace);
            }
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox combo = e.Control as ComboBox;
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if(combo != null)
                {
                    combo.SelectedIndexChanged -= new EventHandler(dtDescripcion_SelectedIndexChanged);
                    combo.SelectedIndexChanged += new EventHandler(dtDescripcion_SelectedIndexChanged);





                }

            }
        }

         void dtDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    ComboBox combo = sender as ComboBox;
                    //selected = combo.SelectedItem.ToString();
                    //MessageBox.Show(combo.SelectedValue.ToString());
                    using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
                    {
                        string query = "SELECT idConcepto, concepto,precio from tipoConcepto where idConcepto = '" + combo.SelectedValue.ToString() + "'";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da1.Fill(dt);

                        //combo.ValueMember = "idConcepto";
                        //combo.DisplayMember = "concepto";
                        combo.DataSource = dt;

                        foreach (DataRow dr in dt.Rows)
                        {
                            double pre = Convert.ToDouble(dr["precio"].ToString());
                            idcon = Convert.ToInt32(dr["idConcepto"].ToString());
                            double costototal = pre * cant;
                            this.dataGridView1.Rows[fila].Cells[3].Value = dr["precio"].ToString();
                            this.dataGridView1.Rows[fila].Cells[4].Value = costototal.ToString();
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if(subtotal == 0)
                                {
                                    subtotal = Convert.ToDouble(row.Cells["dtCostoT"].Value);
                                }
                                else
                                {
                                    subtotal += Convert.ToDouble(row.Cells["dtCostoT"].Value);

                                }

                                //subtotal -= Convert.ToDouble(row.Cells["dtCostoT"].Value);
                                
                                total = (subtotal * 0.16) + subtotal;
                                lbSubTotal.Text = subtotal.ToString();
                                lbTotal.Text = total.ToString();
                            }


                        }

                    }
                }
            }
            catch
            {

            }
               
        }

        void dtMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    ComboBox combo = sender as ComboBox;
                    using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
                    {
                        string query = "SELECT idmes, mes from meses where idmes = '" + mesn + "' ";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da1.Fill(dt);

                        //combo.ValueMember = "idConcepto";
                        //combo.DisplayMember = "concepto";
                        combo.DataSource = dt;
                        foreach (DataRow dr in dt.Rows)
                        {
                            idmes = Convert.ToInt32(dr["idmes"].ToString());
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {

                                if(idmes == mesn)
                                {
                                    mesn = mesn + 1;
                                }
                                else
                                {
                                    //mesn = DateTime.Now.Month;
                                }

                            }
                                } 
                        }
                    }
                }
            catch
            {

            }
        }

            private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = cant;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (idmes == mesn)
                {
                    mesn = mesn + 1;
                }
                else
                {
                    //mesn = DateTime.Now.Month;
                }

            }
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (idmes == mesn)
                {
                    mesn = mesn + 1;
                }
                else
                {
                    //mesn = DateTime.Now.Month;
                }

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(fila);

        }
    }
}
