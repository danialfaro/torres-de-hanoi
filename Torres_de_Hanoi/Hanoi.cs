using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                b.push(a.pop());
                return true;
            }
            else if (b.Top != null && (a.Top == null || b.Top.Valor < a.Top.Valor))
            {
                a.push(b.pop());
                return true;
            }
            return false;
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
