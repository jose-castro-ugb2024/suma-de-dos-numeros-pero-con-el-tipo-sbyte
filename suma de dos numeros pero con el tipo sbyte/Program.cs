using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_dos_numeros_pero_con_el_tipo_sbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num1: ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Num2: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int suma = num1 + num2;

            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, suma);

            Console.ReadLine();
        }
    }
}
