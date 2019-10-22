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
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminSoftNext.Vista
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mostrarGrafica();
            mostrarGrafica2();
        }


        public void mostrarGrafica()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select Direccion , Total from v_calles;";

            // Prepara la conexión
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter mda = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                databaseConnection.Close();
                chart1.Titles.Clear();
                //chart1.Series.Clear();
                //chart1.ChartAreas.Clear();
                chart1.Palette = ChartColorPalette.SeaGreen;
                //ChartArea area = new ChartArea();
                //area.Area3DStyle.Enable3D = true;
                //chart1.ChartAreas.Add(area);
                Title titulo = new Title("Colonos por direccion");
                titulo.Font = new Font("Tahoma", 14, FontStyle.Bold);
                chart1.Titles.Add(titulo);
                //Series serie = new Series("Direcciones");
                //serie.ChartType = SeriesChartType.Bar;
                //serie.XValueMember = "direccion";
                //serie.YValueMembers = "Total";
                
                //serie.IsValueShownAsLabel = true;
                //chart1.Series.Add(serie);
                chart1.DataSource = ds;

            }
            catch
            {

            }
        }

        public void mostrarGrafica2()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=nextadmindb;";
            // Tu consulta en SQL
            string query = "select Direccion , Total from v_calles;";

            // Prepara la conexión
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter mda = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                mda.Fill(ds);
                databaseConnection.Close();
                chart2.Titles.Clear();
                chart2.Series.Clear();
                //chart2.ChartAreas.Clear();
                chart2.Palette = ChartColorPalette.SeaGreen;
                ChartArea area = new ChartArea();
                //area.Area3DStyle.Enable3D = true;
                //chart2.ChartAreas.Add(area);
                Title titulo = new Title("Colonos por direccion");
                titulo.Font = new Font("Tahoma", 14, FontStyle.Bold);
                chart2.Titles.Add(titulo);
                Series serie = new Series("Direcciones");
                serie.ChartType = SeriesChartType.Doughnut;
                serie.XValueMember = "direccion";
                serie.YValueMembers = "Total";
                serie.IsValueShownAsLabel = true;
                chart2.Series.Add(serie);
                chart2.DataSource = ds;

            }
            catch
            {

            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            mostrarGrafica();
            mostrarGrafica2();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDia.Text = DateTime.Now.ToLongDateString();
        }
    }
}
