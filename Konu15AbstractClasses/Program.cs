namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu15AbstractClasses");
            Console.WriteLine();
            // Database database = new Database(); // abstract class bu şekilde new lenemez!!!
            Database sql = new SqlServer(); // Database sınıfından bir örnek oluşturmak için alt sınıflar new lenir.
            sql.Add();
            sql.Get();
            sql.Update();
            sql.Delete();

            Console.WriteLine();

            Database mysql = new MySql();
            mysql.Add();
            mysql.Get();
            mysql.Update();
            mysql.Delete();
        }
    }
    abstract class Database // class ın önüne abstract yazarak yapıyı oluşturuyoruz
    {
        internal void Add() // kayıt ekleme metodu
        {
            Console.WriteLine("Ekleme metodu çalıştı.");
        }
        internal abstract void Delete(); // silme metot imzası
        internal abstract void Update(); // güncelleme metot imzası
        internal abstract void Get(); // veri getirme metot imzası
    }
    class SqlServer : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("SqlServer Delete metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("SqlServer Update metodu çalıştı.");
        }
    }
    class Oracle : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("Oracle Delete metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı.");
        }
    }
    class MySql : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("MySql Delete metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("MySql Update metodu çalıştı.");
        }
    }
}
