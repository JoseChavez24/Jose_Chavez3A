using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccionCineMVC.Clases
{
    public class Aperitivo
    {

        private string nombre;

        public Aperitivo(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
