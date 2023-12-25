using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            //Console.WriteLine("Hello World!");
            char character = 'A';
            bool condition = false;
            byte number4 = 255;
            double number5 = 20.4;
            decimal number6 = 20.4587656m;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 2147483648;


            Console.WriteLine("Number1 is:  {0}", number1);
            Console.WriteLine("Number2 is:  {0}", number2);
            Console.WriteLine("Number3 is:  {0}", number3);
            Console.WriteLine("Number4 is:  {0}", number4);
            Console.WriteLine("Character is:  {0}", (int)character); // (int)character yaparak A'nın sayısal karşılığını aldık
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesdey, Thursday, Friday, Saturday, Sunday
    }
}