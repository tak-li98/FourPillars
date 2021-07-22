using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Tranquilizer : Weapon
    {
        public Tranquilizer(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Pew pew {base.Shoot()}";
        }
    }
}
