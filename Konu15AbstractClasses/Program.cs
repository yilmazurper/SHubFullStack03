namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOnu15Abstractclasses");
            // Database database = new Database(); // abstract class bu sekilde newlenmez !!!
            Database sql = new SqlServer(); // database sinifinden bir ornek olusturmak icin alt siniflar siniflar new'lenir
            sql.Add();
            sql.Get();
            sql.Update();
            sql.Delete();

            Database mysql = new MySql();
                mysql.Add();
            mysql.Get();
            mysql.Update();
            mysql.Delete();

            
        }
    }

    abstract class Database //class'in onune abstract yazarak yapiyi olusturuyoruz
    {
        internal void Add() // kayit ekleme metotu
        {
            Console.WriteLine("ekleme metotu calisti");
        }

        internal abstract void Delete(); // silme metot imzasi
        internal abstract void Update(); // guncelleme metot imzasi 
        internal abstract void Get(); //  veri getirme metot imzasi 
    }
    class SqlServer : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("Sql Delete metotu calisti");
        }

        internal override void Get()
        {
            Console.WriteLine("Sql Get metotu calisti");
        }

        internal override void Update()
        {
            Console.WriteLine("Sql Update metotu  calisti");
        }
    }
    class Oracle : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("Oracle Delete metotu calisti");
        }

        internal override void Get()
        {
            Console.WriteLine("Oracle Get metotu calisti");
        }

        internal override void Update()
        {
            Console.WriteLine("Oracle Update metotu  calisti");
        }
    }
    internal class MySql : Database
    {
        internal override void Delete()
        {
            Console.WriteLine("MySql Delete metotu calisti");
        }

        internal override void Get()
        {
            Console.WriteLine("MySql Get metotu calisti");
        }

        internal override void Update()
        {
            Console.WriteLine("MySql Update metotu  calisti");
        }
    }
}
