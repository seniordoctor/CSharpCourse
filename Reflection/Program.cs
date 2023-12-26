using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);

            //sayi istemez, constr'dan aldi
            //Console.WriteLine(dortIslem.Topla2());

            //bizden sayi ister
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);

            /*DortIslem dortislem = (DortIslem)Activator.CreateInstance(type, 6, 7);*/ // DortIslem dortIslem = new DortIslem(2, 3) --> gelen tipe gore calisma aninda karar verdigimiz icin kullaniyoruz
            //Console.WriteLine(dortislem.Topla(4,5));
            //Console.WriteLine(dortislem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 7);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null)); // GetMethod ile istedigimiz method'a ulasabiliriz, Invoke: GetMethod ile eristigimiz metodu dinamik olarak cagirmak icin kullanilir.

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("-----------------");

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method name : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
             
        }
    }

}
