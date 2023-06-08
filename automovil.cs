using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_final
{
    public class automovil : vehiculo
    {
        int numPuertas;
        int numPasajeros;

        public int NumPuertas { get => numPuertas; set => numPuertas = value; }
        public int NumPasajeros { get => numPasajeros; set => numPasajeros = value; }
    }
}