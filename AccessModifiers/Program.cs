using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id; //private tanımlandigi icin Student class'ta erisilemez.
        protected int id2; //private ile farki inherit edilen class'larda kullanilabilir.



        public void Save()
        {

        }
    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            //id2(); --> protected oldugu icin kullanilabilir.
        }
    }

    // bir class'in default'u internal'dir.
    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }
}
