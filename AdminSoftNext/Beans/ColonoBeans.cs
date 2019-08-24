using AdminSoftNext.Controlador;
using AdminSoftNext.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSoftNext.Beans
{
    class ColonoBeans
    {
        private Colono colono = new Colono();
        internal Colono Colono { get => colono; set => colono = value; }

        public void agregarColono()
        {
            ColonoController colt;
            try
            {
                colt = new ColonoController();
                colt.registrarColono(colono);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
