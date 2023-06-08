using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_final
{
    public class vehiculo
    {
        string placa;
        string marca;
        int modelo;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
    }
}