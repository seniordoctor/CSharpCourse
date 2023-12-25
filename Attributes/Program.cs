using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer{Id = 1, LastName = "MERT", Age = 22};
            CustomerDal customerDal = new CustomerDal();

            customerDal.AddNew(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")] //veritabanlarinda Customers tablosuna denk gelir demektir. Class'a attribute eklemis oluyoruz.
    [ToTable("TblCustomers")] //AllowMultiple ile 2 tane attribute kullanabildik, TblCustomers veya Customers ara seklinde okuyabiliriz.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] //FirstName'i girmesi zorunlu veya baska bir zorunluluk istiyorsak bu sekirde Attribute kullanmalisin.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, istead use AddNew Method")] // HAZIR ATTRIBUTE, OBSOLETE ESKI DEMEK YANI BUNUN YENISI VAR DEMIS OLUYORUZ GIBI ANLAYABILIRSIN
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", 
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //Atribute olusturma, AttributeTargets.All = herkese kullanabilir(class, class-method...),  | AttributeTargets.Field = birden fazla  Attribute kullanimi olusturma, AllowMultiple bir nesne icin 2 defa kullanilabilir mi?
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {
        
    }

    //sadece Class'lara ozel olacak bir Attribute
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute :  Attribute
    {
        private String _tableName;

        public ToTableAttribute(String tableName)
        {
            _tableName = tableName;
        }
    }
}
