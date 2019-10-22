using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Pagos
    {
        int idPago;
        int idColono;

        double total;

        public int IdPago { get => idPago; set => idPago = value; }
        public int IdColono { get => idColono; set => idColono = value; }
        public double Total { get => total; set => total = value; }
    }
}
