using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_final
{
    public partial class _Default : Page
    {

        //Creacion de archivo Json
        public void LeerJson()
        {

            string archivo = Server.MapPath("Pacientess.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            PacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        public void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(PacientesTemp);
            string archivo = Server.MapPath("Pacientess.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}