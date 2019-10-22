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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Vista
{
    public partial class FormularioColonos : Form
    {
        Random rd = new Random();
        ColonoBeans colbn = new ColonoBeans();
        Colono colono = new Colono();
        ColonoController colc = new ColonoController();
         int id = 0;
        public int contCol = 0;
        public int idDato = 0;
        //variables a pasar y recibir del modulo Colono
        public int idCol ;
        int estatus = 0;
        public string nom ;
        public string apepa;
        public string apema;
        public string tel;
        public int dir;
        public int numC ;
        public string email;
        public int prop;
        public int nPro;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormularioColonos()
        {
            InitializeComponent();
           
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        public void datosCalles()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idcalles, nombre from calles";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comboBox1.ValueMember = "idcalles";
                comboBox1.DisplayMember = "nombre";
                comboBox1.DataSource = dt;

            }
        }

        public void datosPropietarios()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idpropietario, tipoPropiedad from propietarios";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comboBox2.ValueMember = "idpropietario";
                comboBox2.DisplayMember = "tipoPropiedad";
                comboBox2.DataSource = dt;

            }
        }

        private void FormularioColonos_Load(object sender, EventArgs e)
        {

            try
            {
                textBox1.Visible = false;
                datosCalles();
                datosPropietarios();
                textBox1.Enabled = false;
                id = rd.Next(111, 2000);
                textBox1.Text = id.ToString();


                if (contCol == 2)
                {
                    textBox1.Text = idCol.ToString();
                    textBox2.Text = nom;
                    textBox3.Text = apepa;
                    textBox4.Text = apema;
                    textBox5.Text = tel;
                    //comboBox1.SelectedValue = dir;
                    //comboBox2.SelectedValue = prop;
                    textBox6.Text = numC.ToString();
                    textBox7.Text = email;
                    textBox9.Text = nPro.ToString();
                    idDato = 1;

                }
            }
            catch
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cargar();
            try
            {


                

                if (contCol == 1)
                {


                    if(textBox2.Text == "" || textBox3.Text == ""|| textBox4.Text == ""
                        || textBox5.Text == ""|| textBox6.Text == ""|| textBox7.Text == ""
                        || textBox9.Text == "")
                    {
                        MessageBox.Show("Campos vacios");
                        textBox1.Text = "";
                        id = rd.Next(10, 10000);
                        textBox1.Text = id.ToString();
                    }
                    else
                    {
                        this.colono.Idcolono = Convert.ToInt32(textBox1.Text);
                        this.colono.Estatus = estatus;
                        this.colono.Nombre = textBox2.Text;
                        this.colono.ApPaterno = textBox3.Text;
                        this.colono.ApMaterno = textBox4.Text;
                        this.colono.Telefono = textBox5.Text;
                        this.colono.Direccion = Convert.ToInt32(comboBox1.SelectedValue);
                        this.colono.Numero = textBox6.Text;
                        this.colono.Email = textBox7.Text;
                        this.colono.Propietario = Convert.ToInt32(comboBox2.SelectedValue);
                        this.colono.NumeroPropiedades = Convert.ToInt32(textBox9.Text);
                        colc.registrarColono(colono);
                       

                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";

                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox9.Text = "";
                        this.Close();
                    }
                    
                   
                }
                else if (contCol == 2)
                {
                    this.colono.Idcolono = Convert.ToInt32(textBox1.Text);
                    this.colono.Nombre = textBox2.Text;
                    this.colono.ApPaterno = textBox3.Text;
                    this.colono.ApMaterno = textBox4.Text;
                    this.colono.Telefono = textBox5.Text;
                    this.colono.Direccion = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                    this.colono.Numero = textBox6.Text;
                    this.colono.Email = textBox7.Text;
                    this.colono.Propietario = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                    this.colono.NumeroPropiedades = Convert.ToInt32(textBox9.Text);
                    colc.modificarColono(colono);
                    this.Close();
                    ModuloColonos md = new ModuloColonos();
                    //idDato = 1;
                    //md.refrescar = 1;
                    md.MostrarDatos();
                    md.Refresh();

                }
            }
            catch
            {

            }

           

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ModificarColono_Click(object sender, EventArgs e)
        {
            this.colono.Idcolono = idCol;
            this.colono.Nombre = textBox2.Text;
            this.colono.ApPaterno = textBox3.Text;
            this.colono.ApMaterno = textBox4.Text;
            this.colono.Telefono = textBox5.Text;
            this.colono.Direccion = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            this.colono.Numero = textBox6.Text;
            this.colono.Email = textBox7.Text;
            this.colono.Propietario = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            this.colono.NumeroPropiedades = Convert.ToInt32(textBox9.Text);
            colc.modificarColono(colono);
            textBox1.Text = id.ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            

        }

        private void PanelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioColonos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModuloColonos frm2 = Application.OpenForms.OfType<ModuloColonos>().FirstOrDefault();

            if (frm2 != null)  //Si encuentra una instancia abierta
            {
                frm2.Refresh();
                frm2.MostrarDatos();
            }
        }
    }
}
