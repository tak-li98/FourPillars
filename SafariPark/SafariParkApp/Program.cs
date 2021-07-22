using System;
using System.Collections.Generic;
namespace SafariParkApp
{
    class Program
    {
        public static void Main()
        {
            Lasso lasso = new Lasso("Rope3000");
            var nish = new Hunter("Nish", "Mandal",lasso);

            List<IShootable> weapons = new List<IShootable>
            {
                lasso,
                new Tranquilizer("Sleepysleepy"),
                new Camera("Canon")
            };

            foreach (IShootable weapon in weapons)
            {
                nish.Shooter = weapon;
                Console.WriteLine(nish.Shoot());
            }
        }
        //public struct Point3D
        //{
        //    public int x, y, z;

        //    public Point3D(int x, int y, int z)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        this.z = z;
        //    }
        //}
        //public static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //}
        //public static void Main()
        //{
        //    List<Object> gameObjects = new List<Object>()
        //    {
        //        new Person("Cathy", "French"),
        //        new Airplane(400,200,"Boeing"){NumPassengers = 300 },
        //        new Vehicle(12,20){NumPassengers = 6 },
        //        new Hunter("Henry","Hodgkins","Pentax")
        //    };
        //    foreach (var o in gameObjects)
        //    {
        //        Console.WriteLine(o);
        //        if (o is Vehicle)
        //        {
        //            var vO = (Vehicle)o;
        //            Console.WriteLine($"Number of passengers: {vO.NumPassengers}");
        //        }
        //    }
        //    Person p1 = new Hunter("Jacob", "Chan") { Age = 20 };
        //    Vehicle plane = new Airplane(250) {NumPassengers = 150, Speed = 300 };
        //    SpartaWrite(p1);
        //    SpartaWrite(plane);

        //    List<IMoveable> theObjects = new List<IMoveable>()
        //    {
        //        new Hunter("John","Wick","Alexa"){Age = 56},
        //        new Airplane(250)
        //    };
        //    foreach(var o in theObjects)
        //    {
        //        Console.WriteLine(o.Move());
        //        Console.WriteLine(o.Move(10));
        //    }

        //static void Main(string[] args)
        //{
        //    Point3D p = new Point3D(3, 6, 2);
        //    var p2 = new Point3D();
        //    var p3 = new Point3D();
        //    Person cathy = new Person("Cathy", "French", 35);
        //    Console.WriteLine(cathy.FullName);

        //    Person nish = new Person() { FirstName = "Nish", Age = 56, LastName = "Mandal" };
        //    Console.WriteLine(nish.FullName);

        //    cathy.Age = 30;
        //    //cathy.Age = -5;
        //    Console.WriteLine($"Cathy is {cathy.Age}");

        //    var james = new Person("James", "Peach") { Age = 51 };

        //    var list = new ShoppingList() { Apple = 8, Battery = 3, BeefJerky = 1, Bread = 1, Honey = 2, Voss = 10 };
        //}
        //public static void Main()
        //{
        //    var h = new Hunter("Mary", "Jones", "Canon") { Age = 32 };
        //    Console.WriteLine(h.Age);
        //    Console.WriteLine(h.Shoot());

        //    //var h2 = new Hunter("Mary", "Jones", "Canon") { Age = 32 };
        //    //Console.WriteLine($"h equals h2? {h.Equals(h2)}");
        //    //Console.WriteLine($"h hashcode {h.GetHashCode()}, h2 hashcode {h2.GetHashCode()}");
        //    //Console.WriteLine($"h type {h.GetType()}");
        //    Console.WriteLine($"h toString {h}");
        //}

        //static void Main(string[] args) 
        //{ 
        //    Airplane a = new Airplane(200, 100, "JetsRUs") 
        //    { NumPassengers = 150 }; 
        //    a.Ascend(500); 
        //    Console.WriteLine(a.Move(3)); 
        //    Console.WriteLine(a); a.Descend(200); 
        //    Console.WriteLine(a.Move()); 
        //    a.Move(); 
        //    Console.WriteLine(a); 
        //}
    }
}
