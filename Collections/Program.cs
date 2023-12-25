using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

                                            // ContainsValue --> degeri de Value sorgusu yapacaktir.
            //Console.WriteLine(dictionary.ContainsKey("glass")); // dictionary icinde glass key olmadigi icin False ciktisi verecek

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); // sadece string turunde veri girisi yapabiliriz
            cities.Add("Ankara");
            cities.Add("Istanbul");

            Console.WriteLine(cities.Contains("Ankara")); // cities icinde Ankara var ise true donecek; yoksa false donecek

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Recep" });
            //customers.Add(new Customer { Id = 2, FirstName = "Naz" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Recep" },
                new Customer { Id = 2, FirstName = "Naz" }
            };

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Nehir"
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName = "Ali"},
                new Customer{Id = 5, FirstName = "Ayse"}
            });

            //Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Recep"})); // new dedigimiz icin yeni bir referans demek oluyor

            //customers.Clear(); // listedeki butun customers'lari siler

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);
            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine("Last Index : {0}", lastIndex);

            customers.Insert(0, customer2);

            customers.Remove(customer2); // remove buldugu ilk customer2 degerini siler, aramaya devam etmez
            customers.RemoveAll(c => c.FirstName == "Nehir");

            //customers.Contains(customer2); // bu listede istedigimiz deger var mi kontrolu yapar

            foreach (var customer in customers)
            {
                //Console.WriteLine(customer); // collection.customer ciktisi verecek
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Customers Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
