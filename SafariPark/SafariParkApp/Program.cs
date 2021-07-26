using System;
using System.Collections.Generic;
namespace SafariParkApp
{
    class Program
    {
        public static void Main()
        {
            List<int> numList = new List<int> { 5, 4, 3, 9, 0 };
            numList.Add(8);
            numList.Sort();
            numList.RemoveRange(1, 2);
            numList.Insert(2, 1);
            numList.Reverse();
            numList.Remove(9);
            foreach(int num in numList)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            //make some people
            var helen = new Person ("Helen","Troy") {Age = 22 };
            var will = new Person ("William","Shakeshack"){ Age = 457 };
            //Queues
            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy"));
            Console.WriteLine("\n Queue");
            foreach (var q in myQueue)
            {
                Console.WriteLine(q);
            }
            var first = myQueue.Peek();
            var serve = myQueue.Dequeue();

            //Stack
            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reversed = new int[original.Length];
            var stack = new Stack<int>();
            foreach (var num in original)
            {
                stack.Push(num);
            }
            reversed = stack.ToArray();

            //HashSet
            var people = new HashSet<Person>
            {
                helen, new Person("Jasmine"), new Person("Chris")
            };
            Console.WriteLine("\n HashSet");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            var success = people.Add(will);
            success = people.Add(helen);
            var morePeople = new HashSet<Person> { will, new Person("Cathy"), new Person("Jasmine") };
            people.IntersectWith(morePeople);
            var vehicleSet = new HashSet<Vehicle>()
            {
                new Vehicle( 5,  2),
                new Vehicle(){Speed = 100}
            };
            success = vehicleSet.Add(new Vehicle() { Speed = 100 });

            //Dictionary
            var personDict = new Dictionary<string, Person>
            {
                {"helen",helen },
                {"sherlock", new Person("Sherlock","Holmes",40) }
            };
            var p = personDict["sherlock"];
            personDict.Add("will", will);

            // count the number of occurances of letter in a string
            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }  
            }
            Console.WriteLine("\n Dictionary problem");
            foreach (var entry in countDict)
            {
                Console.WriteLine(entry);
            }
            foreach (var key in countDict.Keys)
            {
                Console.Write(key+" ");
            }
            Console.WriteLine();
            Console.WriteLine(new String('-',2*countDict.Keys.Count));
            foreach (var value in countDict.Values)
            {
                Console.Write(value + " ");
            }
        }

        //public static void Main()
        //{
        //    var bobOne = new Person("Bob", "Builder") { Age = 25 };
        //    var bobTwo = bobOne;
        //    var areSame = bobOne.Equals(bobTwo);
        //    var bobThree = new Person("Bob", "Builder") { Age = 25 };
        //    Console.WriteLine(bobOne.Equals(bobThree));

        //    List<Person> personList = new List<Person>
        //    {
        //        new Person("Cathy","Cookson"),
        //        new Person("Bob","Builder"){Age = 25 },
        //        new Person("Dan","Dare"),
        //        new Person("Bob","Builder"){Age = 20 },
        //        new Person("Amy","Andrews"){Age=32 }

        //    };
        //    var hasBob = personList.Contains(bobOne);
        //    var bobIndex = personList.IndexOf(bobOne);
        //    var hashCodeOne = bobOne.GetHashCode();
        //    var hasCodeThree = bobThree.GetHashCode();
        //    var notEqual = bobOne != bobThree;

        //    personList.Sort();
        //}
        //public static void Main()
        //{
        //    Lasso lasso = new Lasso("Rope3000");
        //    var nish = new Hunter("Nish", "Mandal",lasso);

        //    List<IShootable> weapons = new List<IShootable>
        //    {
        //        lasso,
        //        new Tranquilizer("Sleepysleepy"),
        //        new Camera("Canon")
        //    };

        //    foreach (IShootable weapon in weapons)
        //    {
        //        nish.Shooter = weapon;
        //        Console.WriteLine(nish.Shoot());
        //    }
        //}
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
