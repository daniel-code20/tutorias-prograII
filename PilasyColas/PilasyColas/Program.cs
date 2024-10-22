using System;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pilas
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int elementoSuperior = stack.Peek();
            Console.WriteLine("Elemento superior con Peek: " + elementoSuperior);
            Console.WriteLine("Elementos en la pila despues del Peek: " + stack.Count);




        }
    }
}
