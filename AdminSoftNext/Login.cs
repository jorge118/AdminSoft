using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminSoftNext.mysql; 

namespace AdminSoftNext
{
    public partial class FrmLogin : Form
    {

        public int usuario = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void txtUusario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtUusario_Enter(object sender, EventArgs e)
        {
            if(txtUsario.Text =="USUARIO"){

                txtUsario.Text = "";
                txtUsario.ForeColor = Color.LightGray;

            }

        }

        private void txtUusario_Leave(object sender, EventArgs e)
        {
            if (txtUsario.Text == "")
            {

                txtUsario.Text = "USUARIO";
                txtUsario.ForeColor = Color.SeaShell;

            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {

                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {

                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.SeaShell;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           
           if(modelo.validarUsuarioYcontraseña(txtUsario.Text,txtPassword.Text)==true)
           {
                 MessageBox.Show("ACCESO CORRECTO");
                usuario = 1;
                this.Close();

            }
            else
            {
                MessageBox.Show("ERROR DE USUARIO O CONTRASEÑA");
                usuario = 2;
            }

                    

            
           
        }

        private void BtnPanel_Click(object sender, EventArgs e)
        {
            panelControl frmControlPanel = new panelControl();
            frmControlPanel.ShowDialog();
        }

        private void BtnDbConexion_Click(object sender, EventArgs e)
        {
            DbConfiguracion nuevoFrmDBConfiguracion = new DbConfiguracion();
            nuevoFrmDBConfiguracion.Show();
        }
    }
}
