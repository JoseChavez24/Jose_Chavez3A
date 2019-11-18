using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccionCineMVC.Clases
{
    public class Recibo
    {
        public Recibo(int numero, string fecha,
            Cliente cliente, float total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            ListaAsientoPorRecibo = listaAsientoPorRecibo;
            Total = total;
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string fecha;
                
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Cliente cliente;

        public Cliente  Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        private List<Asiento> listaAsientoPorRecibo;

        public List<Asiento> ListaAsientoPorRecibo

        {
            get { return listaAsientoPorRecibo; }
            set { listaAsientoPorRecibo = value; }
        }


        private float total;
        public float Total
        {
            get { return total; }
            set { total = value; }
        }


    }
}
