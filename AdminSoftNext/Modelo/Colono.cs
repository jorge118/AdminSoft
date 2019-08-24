using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Colono
    {
        int idcolono;
        string nombre;
        string apPaterno;
        string apMaterno;
        string telefono;
        string direccion;
        
        int numero;
        string email;
        string propietario;
        int numeroPropiedades;

        public int Idcolono { get => idcolono; set => idcolono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public int NumeroPropiedades { get => numeroPropiedades; set => numeroPropiedades = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
