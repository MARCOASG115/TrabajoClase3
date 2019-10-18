using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoClase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Multi;
            int tabla, numero;
            Console.WriteLine(" Ingrse su numero a multiplicar \n ");
            Multi=Convert.ToInt32(Console.ReadLine());
            for (tabla = Multi; tabla <= Multi; tabla++)
            {
                for (numero = 1; numero <= 10; numero++)
                {
                    Console.WriteLine("por " + tabla + " * " + numero + " es: " + tabla * numero);
                }
            }
            Console.WriteLine("Presione cualquier tecla para finalizar el programa");
            Console.ReadKey();
        }
    }
}
