using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leccionCineMVC.Clases;
namespace leccionCineMVC
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Cliente cliente = new Cliente("130252454", "Juan Perez");
            Asiento asiento = new Asiento("Asiento Descripcion: A8");
            Recibo recibo=new Recibo(1,"43/10/2019",cliente,3.20f);
            List<Recibo> recibos = new List<Recibo>();
            recibos.Add(recibo);

            Console.WriteLine("Cine MVC");
            Console.ReadKey();
        }
    }
}
