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
    public partial class FormularioProveedor : Form
    {
        Proveedor pro = new Proveedor();
        ProveedorController proC = new ProveedorController();
        Random rd = new Random();
        int id;
        public int cont;
        public int idProve;
        public string nombrePro;
        public string rSocial;
        public string rfc;
        public string tipo;
        public string dir;
        public string tel;
        public string cel;
        public string email;
        public string estatus;
        int est;
        public FormularioProveedor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormularioProveedor_Load(object sender, EventArgs e)
        {
            datosTipo();
            idTxt.Visible = false;
            id = rd.Next(101, 99991);
            idTxt.Text = id.ToString();
            
            if (cont == 2)
            {
                idTxt.Text = idProve.ToString();
             textBox1.Text = nombrePro;
        rzTxt.Text = rSocial;
       rfcTxt.Text = rfc;
        comboBox1.SelectedValue= tipo;
        dirTxt.Text = dir;
       telfijoTxt.Text = tel;
        celTxt.Text = cel;
        emailTxt.Text = email;


    }
            
        }

        public void datosTipo()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "SELECT idtipoProveeduria, tipoProveeduria from tipoProveedurias";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comboBox1.ValueMember = "tipoProveeduria";
                comboBox1.DisplayMember = "tipoProveeduria";
                comboBox1.DataSource = dt;

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.pro.IdProveedor = Convert.ToInt32(idTxt.Text);
            this.pro.NombreProveedor = textBox1.Text;
            this.pro.RazonSocial = rzTxt.Text;
            this.pro.Rfc = rfcTxt.Text;
            this.pro.TipodeProveeduria = comboBox1.SelectedValue.ToString();
            this.pro.Direccion = dirTxt.Text;
            this.pro.TelefonoFijo = telfijoTxt.Text;
            this.pro.Celular = celTxt.Text;
            this.pro.Email = emailTxt.Text;
            this.pro.Estatus = est; 
            if(cont == 1)
            {
                //id = rd.Next(101, 99991);
                //idTxt.Text = id.ToString();
                proC.altaProveedor(pro);
                idTxt.Text = "";
                textBox1.Text = "";
                rzTxt.Text = "";
                rfcTxt.Text = "";
                dirTxt.Text = "";
                telfijoTxt.Text = "";
                celTxt.Text = "";
                id = rd.Next(101, 99991);
                idTxt.Text = id.ToString();
                this.Close();
            }else if (cont == 2)
            {


                proC.modificarProveedor(pro);
                idTxt.Text = "";
                textBox1.Text = "";
                rzTxt.Text = "";
                rfcTxt.Text = "";
                dirTxt.Text = "";
                telfijoTxt.Text = "";
                celTxt.Text = "";
                id = rd.Next(101, 99991);
                idTxt.Text = id.ToString();
                this.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                est = 1;
            }
            else
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                est = 0;

            }
            else
            {
                checkBox1.Enabled = true;
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

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
