using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Istanbul", "Mugla");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Recep"}, new Customer{FirstName = "Naz"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity
    {
        
    }

    interface IProductDal : IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {
        //List<Customer> GetAll();
        //Customer Get(int id);
        //void Add(Customer product);
        //void Update(Customer product);
        //void Delete(Customer product);
    }

    //kullanici IRepository<T> Generic icin belirli tipleri yazdirmak istiyorum. (örn: bir sinif)
    interface IStudentDal :  IRepository<Student>
    {
        
    }

    interface IEntity
    {
        
    }

    class Student : IEntity
    {
        // IStudentDal : IRepository<Student> yazarsak hata vermez cünkü newlenebilir ve class
    }

    // T:struct deger tiplere karsilik gelir.
    //bunlari tekrar tekrar yazmak istemiyorum, sadece nesne degisiyor bunu kısa yoldan nasil yapariz: T-> Type'tan gelir. class demek referans tip demektir
    interface IRepository<T> where T : class, IEntity, new()                          //generic olarak T verdik ve class(referans tip) oldugunu soyledik. new() ile bunun newlenebilir olmasi gerektigini yazdik. new sonda olmali
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
