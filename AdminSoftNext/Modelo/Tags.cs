using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSoftNext.Modelo
{
    class Tags
    {
        int idTag;
        int numTag;
        int numSitio;
        string tipoVehiculo;
        string numPlacas;
        string color;
        string colono;
        string observaciones;

        public int IdTag { get => idTag; set => idTag = value; }
        public int NumTag { get => numTag; set => numTag = value; }
        public int NumSitio { get => numSitio; set => numSitio = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string NumPlacas { get => numPlacas; set => numPlacas = value; }
        public string Color { get => color; set => color = value; }
        public string Colono { get => colono; set => colono = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
