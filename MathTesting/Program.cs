using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperation;

namespace MathTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c= new Class1();
            ;
            Console.WriteLine(c.Addition(3,5));
            Console.WriteLine(c.Subtraction(3, 5));
            Console.WriteLine(c.Multiplication(3, 5));
            Console.Read();
        }
    }
}
