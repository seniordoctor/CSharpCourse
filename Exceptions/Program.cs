using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) 
            { 
                
            }

            //Method --> parantez acip kapatmak () method'a esittir.
            // => (lambda) karsiligi demek
            // uzun uzun try catch yazmak yerine Handle olusturuyoruz ve asagidaki gibi yazariz - private static void HandleException yazariz.
            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action) // genelde merkezi bir class'in icine koyulur
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Recep", "Naz", "Nehir" };

            if (!students.Contains("Ahmet")) // students icinde Ahmet yoksa;
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Recep", "Naz", "Nehir" };
                students[3] = "Selim";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
