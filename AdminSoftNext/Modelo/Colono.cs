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
        int direccion;
        
        string numero;
        string email;
        int propietario;
        int numeroPropiedades;
        int estatus;
        public int Idcolono { get => idcolono; set => idcolono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Propietario { get => propietario; set => propietario = value; }
        public int NumeroPropiedades { get => numeroPropiedades; set => numeroPropiedades = value; }
        public string Numero { get => numero; set => numero = value; }
        public int Estatus { get => estatus; set => estatus = value; }
    }
}
