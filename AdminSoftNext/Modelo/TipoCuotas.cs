using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class TipoCuotas
    {
        int idConcepto;
        string concepto;
        double costo;

        public int IdConcepto { get => idConcepto; set => idConcepto = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
