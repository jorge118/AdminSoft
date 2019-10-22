using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class TipoPagos
    {
        int idPago;
        string tipo;

        public int IdPago { get => idPago; set => idPago = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
