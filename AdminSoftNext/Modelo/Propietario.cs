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

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string TipoPropiedad { get => tipoPropiedad; set => tipoPropiedad = value; }
    }
}
