using System;

namespace SafariParkApp
{
    class Program
    {
        public struct Point3D
        {
            public int x, y, z;

            public Point3D(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        static void Main(string[] args)
        {
            Point3D p = new Point3D(3, 6, 2);
            var p2 = new Point3D();
            var p3 = new Point3D();
            Person cathy = new Person("Cathy", "French", 35);
            Console.WriteLine(cathy.FullName);

            Person nish = new Person() { FirstName = "Nish", Age = 56, LastName = "Mandal" };
            Console.WriteLine(nish.FullName);

            cathy.Age = 30;
            //cathy.Age = -5;
            Console.WriteLine($"Cathy is {cathy.Age}");

            var james = new Person("James", "Peach") { Age = 51 };

            var list = new ShoppingList() { Apple = 8, Battery = 3, BeefJerky = 1, Bread = 1, Honey = 2, Voss = 10 };
        }
    }
}
