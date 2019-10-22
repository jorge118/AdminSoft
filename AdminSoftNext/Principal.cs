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
using AdminSoftNext.Vista;

namespace AdminSoftNext
{
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            InitializeComponent();

            //FrmLogin frmRegistro = new FrmLogin();
            //frmRegistro.ShowDialog();
            //subPanel.Visible = false;
            mostrarDashboard();
            subPanel1.Visible = false;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
         
     

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
           
           // this.WindowState = FormWindowState.Normal;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width <= 60)
            {
                TmOcultarMenu.Enabled = false;
            }
            else
                PanelMenu.Width = PanelMenu.Width - 20;
    }

        private void TmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width >= 145)
            {
               TmMostrarMenu.Enabled = false;
            }
            else
                PanelMenu.Width = PanelMenu.Width + 20;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 145)
            {

                TmOcultarMenu.Enabled = true;
            } else if (PanelMenu.Width == 60)
            {

            }
            else
                TmMostrarMenu.Enabled = true; 
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {

        }

        private void BtnHerramientas_Click(object sender, EventArgs e)
        {

            FrmLogin frmRegistro = new FrmLogin();
            frmRegistro.ShowDialog();

            if(frmRegistro.usuario == 1)
            {
                subPanel1.Visible = true;


            }
            else
            {
                subPanel1.Visible = false;
            }
            // PanelContenedor.
            //if(subPanel1.Visible == false)
            //{
            //    subPanel1.Visible = true;
            //    this.PanelContenedor.Controls.Add(subPanel1);
            //    if (this.PanelContenedor.Controls.Count > 0)
            //        this.PanelContenedor.Controls.RemoveAt(0);
            //}
            //else
            //{
            //    subPanel1.Visible = false;
            //}

        }

        private void BtnColono_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloColonos hijo1 = new ModuloColonos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void btnCalles_Click(object sender, EventArgs e)
        {
            
            FormularioCalles hijo1 = new FormularioCalles();
           
            hijo1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloPropietario hijo1 = new ModuloPropietario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloTags hijo1 = new ModuloTags();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloProveedor hijo1 = new ModuloProveedor();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            CatalogoTiposProveeduria hijo1 = new CatalogoTiposProveeduria();
            
            hijo1.ShowDialog();
        }

        private void Btnpagos_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloPagos hijo1 = new ModuloPagos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            subPanel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormularioTiposPago ftp = new FormularioTiposPago();
            ftp.ShowDialog();
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            mostrarDashboard();
        }


        public void mostrarDashboard()
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Dashboard hijo1 = new Dashboard();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloCuotas hijo1 = new ModuloCuotas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ModuloSaldos hijo1 = new ModuloSaldos();
    
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(hijo1);
            this.PanelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BtnComvenios_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoCoutas_Click(object sender, EventArgs e)
        {
            ModuloTipoCuotas mc = new ModuloTipoCuotas();
            mc.Show();
        }
    }
}
