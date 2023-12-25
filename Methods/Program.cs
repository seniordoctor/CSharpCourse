using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int number1 = 20;
            //int number2 = 100;

            //var result = Add2(20, 40);
            //var result2 = Add3(ref number1, number2); // ref keyword ile yukarı atanan sayi yerine static Add3 icerisindeki degeri referans deger olarak alacaktir.
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(2, 3, 4, 5, 6, 7, 8));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        // number2 = 30 --> eger yukarida Add2() icerisinde number2 degeri verilmez ise default olarak 30 alacaktir.
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }


        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        // Method Overloading yapamayacak kadar fazla int veya farkli veri tipinde deger girilecegi zaman params keyword ile calisabiliriz.
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();   // Sum() ile params icindekileri toplayacak.
        }
    }
}
