using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

/*A partir del dinero que tienes, 
 * y el interes que te van a dar
 marca tu objetivo y tendrás los
 años que tendrás que esperar.*/

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, porcentajeInteres, objetivo;
            WriteLine("¿Cuánto dinero tienes?");
            balance = ToDouble(ReadLine());
            WriteLine("¿Cuál es el % de interés anual?");
            porcentajeInteres = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("¿Cuánto dinero queires obtener?");
            objetivo = ToDouble(ReadLine());
            int anosTotales = 0;
            while (balance < objetivo)
            {
                balance *= porcentajeInteres;
                ++anosTotales;
            }
            WriteLine($"En {anosTotales} año{(anosTotales == 1 ?"": "s")} tu tendrás un saldo de {balance}");
            if (anosTotales == 0)
                WriteLine("¿Para qué necesitas está calculadora?");
            ReadKey();
        }
    }
}
