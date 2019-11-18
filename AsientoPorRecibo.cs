using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccionCineMVC.Clases
{
    public class AsientoPorRecibo
    {
        public AsientoPorRecibo(Asiento asiento, Recibo recibo, List<Aperitivo> listaAperitivo)
        {
            Asiento = asiento;
            Recibo = recibo;
            ListaAperitivo = listaAperitivo;
        }

        private Asiento asiento;

        public Asiento Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

        private Recibo recibo;

        public Recibo Recibo
        {
            get { return recibo; }
            set { recibo = value; }
        }

        private List<Aperitivo> listaAperitivo;

       
        public List<Aperitivo> ListaAperitivo
        {
            get { return listaAperitivo; }
            set { listaAperitivo = value; }
        }



    }
}
