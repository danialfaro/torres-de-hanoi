using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public string Name;

        public int Size;

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        public Disco Top;

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */
        public List<Disco> Elementos;

        /* TODO: Implementar métodos */
        public Pila(string name)
        {
            Name = name;
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d;
            Size = Elementos.Count;
        }

        public Disco pop()
        {
            Disco top = Top;
            Elementos.Remove(Top);
            Top = Elementos.Count > 0 ? Elementos[Elementos.Count - 1] : null;
            Size = Elementos.Count;
            return top;
        }

        public bool isEmpty()
        {
            return Elementos.Count == 0;
        }

    }
}
