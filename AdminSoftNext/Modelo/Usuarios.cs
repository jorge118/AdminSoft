using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Usuarios
    {
        int idusuario;
        string usuario;
        string contrasena;
        int idPermisos;

        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int IdPermisos { get => idPermisos; set => idPermisos = value; }
    }
}
