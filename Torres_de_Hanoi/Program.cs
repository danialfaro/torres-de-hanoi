using System;

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

            int m = -1;
            while (m == -1)
            {
                Console.WriteLine("¿Qué método quieres usar? Iterativo (I) o Recursivo (R):");
                string inputType = Console.ReadLine();
                if (inputType.Equals("I")) m = hanoi.iterativo();
                else if (inputType.Equals("R")) m = hanoi.recursivo();
                else Console.WriteLine("Carácter no válido.");
            }

            Console.WriteLine(m);

            bool ok = m == Math.Pow(2, n) - 1;
            Console.WriteLine(ok);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
