using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSoftNext.mysql;

namespace AdminSoftNext
{
    public partial class DbConfiguracion : Form
    {

        public DbConfiguracion()
        {
            InitializeComponent();

            List <string> datos  = modelo.leerArchivoTextodb();
            if (datos!=null)
            {
                TxtSrv.Text = datos[0].ToString();
                TxtDb.Text = datos[1].ToString();
                txtUsuario.Text = datos[2].ToString();
                txtContraseña.Text = datos[3].ToString();


            }else
            {
                MessageBox.Show("EL ARCHIVO DE CONFIGURACION DE LA BASE DE DATOS ESTA VACIO");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            StreamWriter wr = new StreamWriter("C:\\Users\\Jorge\\Documents\\Soft\\nextadmindb\\dbConexion.txt");
           try {

                wr.WriteLine(TxtSrv.Text);
                wr.WriteLine(TxtDb.Text);
                wr.WriteLine(txtUsuario.Text);
                wr.WriteLine(txtContraseña.Text);
            }catch{
                MessageBox.Show("ERROR AL GURDAR LA INFORMACION");
            }
            wr.Close();
            this.Close();
        }

        private void TxtSrv_Enter(object sender, EventArgs e)
        {
            if (TxtSrv.Text == "SERVIDOR")
            {

                TxtSrv.Text = "";
                TxtSrv.ForeColor = Color.LightGray;

            }
        }

        private void TxtSrv_Leave(object sender, EventArgs e)
        {
            if (TxtSrv.Text == "")
            {

                TxtSrv.Text = "SERVIDOR";
                TxtSrv.ForeColor = Color.SeaShell;

            }
        }

        private void TxtDb_Enter(object sender, EventArgs e)
        {
            if (TxtDb.Text == "BASE DE DATOS")
            {

                TxtDb.Text = "";
                TxtDb.ForeColor = Color.LightGray;

            }
        }

        private void TxtDb_Leave(object sender, EventArgs e)
        {
            if (TxtDb.Text == "")
            {

                TxtDb.Text = "BASE DE DATOS";
                TxtDb.ForeColor = Color.SeaShell;

            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {

                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {

                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.SeaShell;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {

                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {

                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.SeaShell;

            }
        }

        private void BtnPruebaConexion_Click(object sender, EventArgs e)
        {
            bool conexionOk = false;

            conexionOk =  modelo.pruebaConexion("server = " + TxtSrv.Text + "; database = " + TxtDb.Text + "; uid = " + txtUsuario.Text + "; pwd = " + txtContraseña.Text + ";");
            if (conexionOk==true)
            {
                MessageBox.Show("conexion exitosa");
                BtnAceptar.Enabled = true;
            } else
                MessageBox.Show("Error de conexion a la base de datos");
        }
    }
}
