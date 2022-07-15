using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate<int> calc1 = new Calculate<int>(8, 4);
            Console.WriteLine(calc1.Add());
            Console.WriteLine(calc1.Sub());
            Console.WriteLine(calc1.Multiply());
            Console.WriteLine(calc1.Divide());

            Console.WriteLine("\n");

            Calculate<double> calc2 = new Calculate<double>(15.6, 5.2);
            Console.WriteLine(calc2.Add());
            Console.WriteLine(calc2.Sub());
            Console.WriteLine(calc2.Multiply());
            Console.WriteLine(calc2.Divide());

            Console.WriteLine("\n");

            Calculate<string> calc3 = new Calculate<string>("18", "6");
            Console.WriteLine(calc3.Add());
            Console.WriteLine(calc3.Sub());
            Console.WriteLine(calc3.Multiply());
            Console.WriteLine(calc3.Divide());



            Console.ReadLine();
        }
    }
}
