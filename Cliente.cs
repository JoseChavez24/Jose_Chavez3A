using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccionCineMVC.Clases
{
    public class Cliente
    {

        public Cliente(string identificacion, string nombre)
        {
            Identificacion = identificacion;
            Nombre = nombre;
        }

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Recibo> listaRecibo;

        public List<Recibo> ListaRecibo
        {
            get { return listaRecibo; }
            set { listaRecibo = value; }
        }



    }
}
