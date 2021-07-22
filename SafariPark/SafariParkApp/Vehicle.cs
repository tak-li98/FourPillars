using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        protected int _capacity;
        protected int _numPassengers;

        public int Position { get; set; }

        public int Speed { get; init; }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

        public Vehicle()
        {
            Speed = 10;
        }

        public int NumPassengers { 
            get { return _numPassengers;}
            set { if(value<0 || value > _capacity)
                {
                    throw new ArgumentException("Number of passengers exceed capacity or is less than zero!");
                }
                _numPassengers = value;
                }
            }

        public int TimesMoved => throw new NotImplementedException();

        public virtual string Move()
        {
            Position += Speed;
            return $"Moving along";
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;
            return $"Moving along {times} times";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}