using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCorbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Personajes persona1 = new Personajes();
            Habitacion cuarto1 = new Habitacion();

            /*-----------------------Sistema momentual de pruebas--------------------------*/

            persona1.miNombre = "Raquel";

            cuarto1.agregar_persona(persona1.miNombre);
            cuarto1.agregar_persona("Werro");
            cuarto1.agregar_persona("Dr. Alpaca");
            cuarto1.agregar_persona("La luchona Bucanera");
            cuarto1.agregar_persona("pancho");

            Console.WriteLine(persona1);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(cuarto1);
            cuarto1.salir("Raquel");
            Console.WriteLine(cuarto1);
            if (cuarto1.estasAhi("Raquel")) Console.WriteLine("si");
            else Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
