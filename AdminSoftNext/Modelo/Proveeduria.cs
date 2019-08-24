using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Proveeduria
    {
        int idProveeduria;
        string tipoProveeduria;

        public int IdProveeduria { get => idProveeduria; set => idProveeduria = value; }
        public string TipoProveeduria { get => tipoProveeduria; set => tipoProveeduria = value; }
    }
}
