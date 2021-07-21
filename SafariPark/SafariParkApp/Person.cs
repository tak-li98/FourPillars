using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person 
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
        public Person()
        {

        }
        public string FullName => (LastName.Length>0)?$"{FirstName} {LastName}":FirstName;

        public override string ToString()
        {
            return $"{base.ToString()} Name:{FirstName} Age: {Age}";
        }
    }
}