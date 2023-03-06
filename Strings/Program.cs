using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();



            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";

            Console.WriteLine(string.Format("{0}{1}", city, city2));
        }
    }
}
