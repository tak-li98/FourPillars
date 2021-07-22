using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter{get;set;}
        public Hunter(string fName, string lName, IShootable shooter) : base(fName,lName)
        {
            Shooter = shooter;
        }
        public Hunter() { }
        public string Shoot()
        {
            return $"{FullName}: {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Shooter: {Shooter}";
        }
    }
}