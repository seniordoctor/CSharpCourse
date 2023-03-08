using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract classlar new'lenemez
            //Database database = new Database();
            Database oracleDatabase = new Oracle();
            oracleDatabase.Add();
            oracleDatabase.Delete();

            Database sqlDatabase = new SqlServer();
            sqlDatabase.Add();
            sqlDatabase.Delete();

            Console.ReadLine();
        }
    }
    // abstract class: new'lenemez, degisken ve metod bulunabilir.
    // abstract class'tan turetilen class'ların abstract metodlari implement etmesi zorunludur. Diger metodları override etmeden de kullanabilir.
    // static tanimlanamaz
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
