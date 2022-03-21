using System;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int n;
        private Pila ini, aux, fin;

        public Hanoi(int n)
        {
            this.n = n;
            ini = new Pila("INI");
            aux = new Pila("AUX");
            fin = new Pila("FIN");

            for (int i = n; i > 0; i--)
            {
                ini.push(new Disco(i));
            }
        }

        /*TODO: Implementar métodos*/
        public bool mover_disco(Pila a, Pila b)
        {

            if (a.Top != null && (b.Top == null || a.Top.Valor < b.Top.Valor))
            {
                Console.WriteLine("Movimiento de la pila " + a.Name + " a " + b.Name + " - Disco: " + a.Top.Valor);
                b.push(a.pop());
                ImprimirInfoPilas();
                return true;
            }
            else if (b.Top != null && (a.Top == null || b.Top.Valor < a.Top.Valor))
            {
                Console.WriteLine("Movimiento de la pila " + b.Name + " a " + a.Name + " - Disco: " + b.Top.Valor);
                a.push(b.pop());
                ImprimirInfoPilas();
                return true;
            }

            return false;
        }

        public int iterativo()
        {
            int m = 0;
            if (n % 2 != 0)
            {
                while (fin.Size < n)
                {
                    if (mover_disco(ini, fin)) m++;
                    if (fin.Size == n) break;
                    if (mover_disco(ini, aux)) m++;
                    if (mover_disco(aux, fin)) m++;
                }
            }
            else if (n % 2 == 0)
            {
                while (fin.Size < n)
                {
                    if (mover_disco(ini, aux)) m++;
                    if (mover_disco(ini, fin)) m++;
                    if (fin.Size == n) break;
                    if (mover_disco(aux, fin)) m++;
                }
            }
            return m;
        }

        public int recursivo()
        {
            int m = algoritmoRecursivo(n, ini, fin, aux);
            return m;
        }

        private int algoritmoRecursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n == 1)
            {
                if (mover_disco(ini, fin)) m++;
            }
            else
            {
                m += algoritmoRecursivo(n - 1, ini, aux, fin);
                if (mover_disco(ini, fin)) m++;
                m += algoritmoRecursivo(n - 1, aux, fin, ini);
            }
            return m;
        }

        public void ImprimirInfoPilas()
        {
            Console.WriteLine("        " + ini.Name + ": " + string.Join(", ", ini.Elementos));
            Console.WriteLine("        " + aux.Name + ": " + string.Join(", ", aux.Elementos));
            Console.WriteLine("        " + fin.Name + ": " + string.Join(", ", fin.Elementos));
            Console.WriteLine("================================================================");
        }

    }
}
