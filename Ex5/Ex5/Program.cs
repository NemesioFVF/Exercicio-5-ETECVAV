using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da variável 'a': ");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor da variável 'b': ");
            Int32 b = Convert.ToInt32(Console.ReadLine());
            Int32 c = a;
            a = b;
            b = c;
            Console.WriteLine("Variável 'a' = " + a);
            Console.WriteLine("Variábel 'b' = " + b);
            Console.ReadKey();
        }
    }
}
