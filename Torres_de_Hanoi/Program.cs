using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep the console window open in debug mode.
            Console.WriteLine("Introduce el numero de discos totales:");
            string inputNum = Console.ReadLine();
            int n = int.Parse(inputNum);
            Hanoi hanoi = new Hanoi(n);

            int m = hanoi.iterativo();
            Console.WriteLine(m);

            bool ok = m == Math.Pow(2, n) - 1;
            Console.WriteLine(ok);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
