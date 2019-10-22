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
    public partial class FormularioSaldos : Form
    {
        SaldosController sc = new SaldosController();
        Saldos sa = new Saldos();
        Random rd = new Random();
        int idsaldo = 0;
        public int opc = 0;
        public int idColono = 0;
        public int idSal = 0;
        public FormularioSaldos()
        {
            InitializeComponent();
        }

        private void FormularioSaldos_Load(object sender, EventArgs e)
        {
            try
            {
                datosColono();
                lblSaldo.Visible = false;
                idsaldo = rd.Next(1, 99999);


                lblSaldo.Text = idsaldo.ToString();
                if(opc == 2)
                {
                    this.sa.IdSaldo = idSal;
                    this.sa.Idcolono = idColono;
                    this.sa.SaldoInicial = Convert.ToDouble(txtSaldo.Text);
                    this.sa.Comentarios = txtComentarios.Text;
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message + "   " + ex.StackTrace);
            }

        }


        public void datosColono()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "select idcolono, concat(nombre,' ',apPaterno,' ' ,apMaterno) as Colono from v_col;";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comColono.ValueMember = "idcolono";
                comColono.DisplayMember = "Colono";
                comColono.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (opc == 1)
                {
                    this.sa.IdSaldo = Convert.ToInt32(lblSaldo.Text);
                    this.sa.Idcolono = Convert.ToInt32(comColono.SelectedValue.ToString());
                    this.sa.SaldoInicial = Convert.ToDouble(txtSaldo.Text);
                    this.sa.Comentarios = txtComentarios.Text;
                    sc.insertarSaldo(sa);
                    this.Close();
                    ModuloSaldos frm9 = Application.OpenForms.OfType<ModuloSaldos>().FirstOrDefault();

                    if (frm9 != null)  //Si encuentra una instancia abierta
                    {
                        frm9.Refresh();
                        frm9.MostrarDatos();
                    }
                }
                else if (opc == 2)
                {
                    this.sa.IdSaldo = idSal;
                    this.sa.Idcolono = idColono;
                    this.sa.SaldoInicial = Convert.ToDouble(txtSaldo.Text);
                    this.sa.Comentarios = txtComentarios.Text;
                    sc.actualizarSaldo(sa);
                    this.Close();
                    ModuloSaldos frm9 = Application.OpenForms.OfType<ModuloSaldos>().FirstOrDefault();

                    if (frm9 != null)  //Si encuentra una instancia abierta
                    {
                        frm9.Refresh();
                        frm9.MostrarDatos();
                    }
                }
            }
            catch
            {

            }
        }

        private void FormularioSaldos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModuloSaldos frm9 = Application.OpenForms.OfType<ModuloSaldos>().FirstOrDefault();

            if (frm9 != null)  //Si encuentra una instancia abierta
            {
                frm9.Refresh();
                frm9.MostrarDatos();
            }
        }
    }
}
