using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class DetallePagos
    {
        int idDetallePago;
        int idPago;
        int idConcepto;
        int cantidad;
        int idmes;
        double costoUnitario;
        double costoTotal;
        double Total;
        int idtipo;

        public int IdDetallePago { get => idDetallePago; set => idDetallePago = value; }
        public int IdPago { get => idPago; set => idPago = value; }
        public int IdConcepto { get => idConcepto; set => idConcepto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public double CostoTotal { get => costoTotal; set => costoTotal = value; }
        public double Total1 { get => Total; set => Total = value; }
        public int Idtipo { get => idtipo; set => idtipo = value; }
        public int Idmes { get => idmes; set => idmes = value; }
    }
}
