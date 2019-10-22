using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Propietario
    {
        int idPropietario;
        string tipoPropiedad;
        double costo;

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string TipoPropiedad { get => tipoPropiedad; set => tipoPropiedad = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
