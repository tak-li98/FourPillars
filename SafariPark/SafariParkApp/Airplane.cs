using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        public int Altitude { get; private set; }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public Airplane(int capacity)
        {

        }
        public void Ascend(int distance)
        {
            
            if (distance >100000)
            {
                throw new ArgumentException("You will be beyond Earth!");
            }
            Altitude += distance;
        }
        public void Descend(int distance)
        {
            if (distance < 0)
            {
                throw new ArgumentException("Descend distance can't be negative!!");
            }
            if (Altitude - distance < 0)
            {
                throw new ArgumentException("Altitude is less than zero!");
            }
            Altitude -= distance;  
        }
        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres";
        }
        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres";
        }
        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers: {_numPassengers} " +
                $"speed: {Speed} position: {Position} altitude: {Altitude}";
        }
    }
}