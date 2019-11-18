using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccionCineMVC.Clases
{
    public class Asiento
    {
        public Asiento(string descripcion)
        {
            Descripcion = descripcion;
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
