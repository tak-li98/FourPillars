using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;
        public Camera(string brand)
        {
            _brand = brand;
        }
        public void Focus()
        {

        }
        public string Shoot()
        {
            return $" Taking photos with: {_brand}";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
