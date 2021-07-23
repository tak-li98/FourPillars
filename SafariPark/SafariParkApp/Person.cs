using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMoveable, IEquatable<Person>, IComparable<Person>
    {
        public string FirstName { get; init; } = "";
        public string LastName { get; init; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }
        //public int Age { get; init; }

        public Person(string firstName, string lastName, int age )
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName, string lastName) //incase age is set 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(string firstName)
        {
            FirstName = firstName;
        }
        public Person()
        {

        }
        public string FullName => (LastName.Length>0)?$"{FirstName} {LastName}":FirstName;

        public int TimesMoved => throw new NotImplementedException();

        public override string ToString()
        {
            return $"{base.ToString()} Name:{FirstName} Age: {Age}";
        }

        public string Move()
        {
            return $"Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Age == other.Age;
        
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Age);
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else 
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right) 
        {
            return !(left == right);
        }
    }
}