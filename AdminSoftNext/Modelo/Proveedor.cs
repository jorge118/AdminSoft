using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Proveedor
    {
        int idProveedor;
        string nombreProveedor;
        string razonSocial;
        string rfc;
        string tipodeProveeduria;
        string direccion;
        string telefonoFijo;
        string celular;
        string email;
        int estatus;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string TipodeProveeduria { get => tipodeProveeduria; set => tipodeProveeduria = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string TelefonoFijo { get => telefonoFijo; set => telefonoFijo = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public int Estatus { get => estatus; set => estatus = value; }
    }
}
