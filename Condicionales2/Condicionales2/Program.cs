using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pago, entrada, deuda;

            Console.WriteLine("Buenos días, ha pagado la entrada?");
            pago = Console.ReadLine();

            if (pago.ToLower() == "si" ||pago.ToLower() == "sí")
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Debes pagar la entrada");
            }

            Console.WriteLine("¿Qué entrada tiene?");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "vip")
            {
                Console.WriteLine("Que pase un buen día.");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }

            Console.WriteLine("¿Tiene deudas?");
            deuda = Console.ReadLine();

            if (deuda.ToLower() == "si")
            {
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Bienvenido");
            }

          
            //Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            if (entrada.ToLower() == "vip" && deuda == "no" && (pago.ToLower() == "si" || pago.ToLower() =="sí"))
            Console.WriteLine("Bienvenido cliente VIP con saldo.");
            Console.ReadLine();

        }
    }
}
