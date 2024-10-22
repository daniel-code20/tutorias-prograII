
using System;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colas

            Queue<int> cola = new Queue<int>();

            cola.Enqueue(10);
            cola.Enqueue(20);
            cola.Enqueue(30);

            int primerElemento = cola.Peek();
            Console.WriteLine("Elemento en el top con Peek: " + primerElemento);
            Console.WriteLine("Elementos en la cola depues de Peek: " + cola.Count);


        }
    }
}
