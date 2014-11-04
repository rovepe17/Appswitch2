using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appswitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("programa sentencia switch");
            Console.WriteLine("los numeros");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine(" numero fuera de rango:");
                    break;
            }

            Console.ReadKey();
        }
    }
}

