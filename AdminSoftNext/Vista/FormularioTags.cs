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
    public partial class FormularioTags : Form
    {
        Tags tg = new Tags();
        TagController tagC = new TagController();
        public int cont = 0;
        Random rd = new Random();
        int id;
        public int idTags;
        public int numTag;
        public int numSitio2;
        public string tipVehiculo;
        public string placas;
        public string color;
        public string obser;
        double formTag;
        public FormularioTags()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tagTxt.Text == "" || colorTxt.Text == "" || placasTxt.Text == "")
            {
                MessageBox.Show("Llene los campos requeridos");
            }
            else
            {
                this.tg.IdTag = Convert.ToInt32(idText.Text);
                this.tg.NumTag = Convert.ToInt32(tagTxt.Text);
                this.tg.NumSitio = Convert.ToInt32(sitioTxt.Text);
                this.tg.TipoVehiculo = vehiTxt.Text;
                this.tg.NumPlacas = placasTxt.Text;
                this.tg.Color = colorTxt.Text;
                this.tg.Colono = comboBox1.SelectedValue.ToString();
                this.tg.Observaciones = textObser.Text;
            }

          


            if (cont == 1)
            {

                if (tagTxt.Text == ""||colorTxt.Text == ""|| placasTxt.Text == "")
                {
                    MessageBox.Show("Llene los campos requeridos");
                }
                else
                {
                    tagC.registrarTag(tg);
                    this.Close();
                }

                
            }
            else if (cont == 2)
            {
                if (tagTxt.Text == "" || colorTxt.Text == "" || placasTxt.Text == "")
                {
                    MessageBox.Show("Llene los campos requeridos");
                }
                else
                {
                    tagC.modificarTag(tg);
                    this.Close();
                }
               
            }
            
        }

        public void cargar()
        {
            try
            {

            }
            catch
            {

            }
            this.tg.IdTag = Convert.ToInt32(idText.Text);
            this.tg.NumTag = Convert.ToInt32(tagTxt.Text);
            this.tg.NumSitio = Convert.ToInt32(sitioTxt);
            this.tg.TipoVehiculo = vehiTxt.Text;
            this.tg.NumPlacas = placasTxt.Text;
            this.tg.Color = colorTxt.Text;
            this.tg.Colono = comboBox1.SelectedValue.ToString();
            this.tg.Observaciones = textObser.Text;
        }

        public void datosColono()
        {
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=nextadmindb;Uid=root;pwd=root"))
            {
                string query = "select concat(Direccion,' ',numero) as DireccionColono from vista_colono";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                comboBox1.ValueMember = "DireccionColono";
                comboBox1.DisplayMember = "DireccionColono";
                comboBox1.DataSource = dt;

            }
        }
        private void FormularioTags_Load(object sender, EventArgs e)
        {
            datosColono();
            idText.Visible = false;
            id = rd.Next(100, 99001);
            idText.Text = id.ToString();



            if (idText.Text == "0")
            {
                id = rd.Next(100, 99001);
                idText.Text = id.ToString();
            }

            if (cont == 2)
            {
                idText.Text = idTags.ToString();
                tagTxt.Text = numTag.ToString();
                sitioTxt.Text = numSitio2.ToString();
                vehiTxt.Text = tipVehiculo.ToString();
                placasTxt.Text = placas.ToString();
                colorTxt.Text = color.ToString();
                textObser.Text = obser.ToString();
            }

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

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxTag_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTag.Checked == true)
            {
                txtReactivo.Enabled = false;
                sitioTxt.Enabled = false;
                txtNum.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                txtReactivo.Enabled = true;
                sitioTxt.Enabled = true;
                txtNum.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBoxTag.Enabled = false;
                tagTxt.Enabled = false;

            }
            else
            {
                checkBoxTag.Enabled = true;
                tagTxt.Enabled = true;
            }
        }

        private void sitioTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sitio = Convert.ToInt32(sitioTxt.Text);
                int react = Convert.ToInt32(txtReactivo.Text);
                formTag = (sitio * 65536) + react;
                tagTxt.Text = formTag.ToString();
            }
            catch
            {
                //MessageBox.Show("");
            }
        }

        private void FormularioTags_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModuloTags frm4 = Application.OpenForms.OfType<ModuloTags>().FirstOrDefault();

            if (frm4 != null)  //Si encuentra una instancia abierta
            {
                frm4.Refresh();
                frm4.MostrarDatos();
            }
        }
    }
}
