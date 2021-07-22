using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Lasso : Weapon
    {
        public Lasso(string brand) : base(brand)
        {

        }
        public override string Shoot()
        {
            return $"Wapeesh Wapeesh {base.Shoot()}";
        }
    }
}
