using System;

namespace ModificadorDeParametroOut
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10; 
            int triple;
            Calculator.Triple(a, out triple); // a (parametro input) triple (parametro Output)
            Console.WriteLine(triple);


        }
    }
}
