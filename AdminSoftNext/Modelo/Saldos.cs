using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Saldos
    {
        int idSaldo;
        double saldoInicial;
        int idcolono;
        string comentarios;

        public int IdSaldo { get => idSaldo; set => idSaldo = value; }
        public double SaldoInicial { get => saldoInicial; set => saldoInicial = value; }
        public int Idcolono { get => idcolono; set => idcolono = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
    }
}
