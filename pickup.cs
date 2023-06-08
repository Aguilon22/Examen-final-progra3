using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_final
{
    public class pickup : vehiculo
    {
        string cilindrada;
        string electrica;

        public string Cilindrada { get => cilindrada; set => cilindrada = value; }
        public string Electrica { get => electrica; set => electrica = value; }
    }
}