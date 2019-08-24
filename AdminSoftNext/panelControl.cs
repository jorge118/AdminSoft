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

namespace AdminSoftNext
{
    public partial class panelControl : Form
    {
        
        int lastError;
        IntPtr idConeccion = IntPtr.Zero;
        int ret = 0;
        int operid = 0;
        int doorid = 0;
        int outputadr= 0;
        int doorstate = 0;
        public panelControl()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        [DllImport("c:\\Windows\\SysWOW64\\plcommpro.dll", EntryPoint = "Connect")]
        private extern static IntPtr Connect(String cadenaConexion);

        [DllImport("c:\\Windows\\SysWOW64\\plcommpro.dll", EntryPoint = "PullLastError")]
        private extern static int PullLastError();

        [DllImport("plcommpro.dll", EntryPoint = "ControlDevice")]
        public static extern int ControlDevice(IntPtr h, int operationid, int param1, int param2, int param3, int param4, string options);



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            string con = "protocol=TCP,ipaddress=192.168.1.201,port=4370,timeout=2000,passwd=";
            idConeccion = Connect(con);

            if (idConeccion != IntPtr.Zero) {

                MessageBox.Show("CONEXION EXITOSA");
                BtnRelevador1.Enabled = true;
            } else {

                lastError = PullLastError();
                MessageBox.Show("Error: " + lastError.ToString());


            }
        }

        private void BtnRelevador1_Click(object sender, EventArgs e)
        {
             IntPtr h = IntPtr.Zero;
             ret = ControlDevice(h,1,0,0,8,0,"");
             MessageBox.Show("Error: " + ret.ToString());
        }
    }
}




