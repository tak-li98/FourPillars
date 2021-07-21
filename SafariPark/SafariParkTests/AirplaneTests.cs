using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SafariParkApp;

namespace SafariParkTests
{
    public class AirplaneTests
    {
        [Test]
        public void WhenAnAirplanesMovesTwiceItsPositionIs200()
        {
            Airplane v = new Airplane(200) { Speed = 100 };
            var result = v.Move(2);
            Assert.AreEqual(200, v.Position);
            Assert.AreEqual("Moving along 2 times at an altitude of 0 metres", result);
        }

        [Test]
        public void WhenAnAirplaneWithSpeed100IsMovedOnceItsPositionIs100()
        {
            Airplane v = new Airplane(250,100,"EasyJet");
            var result = v.Move();
            Assert.AreEqual(100, v.Position);
            Assert.AreEqual("Moving along at an altitude of 0 metres", result);
        }

        [Test]
        public void WhenAnAirplaneAscends350Metres_PositionIs350()
        {
            Airplane v = new Airplane(250);
            v.Ascend(350);
            Assert.AreEqual(350, v.Altitude);
        }
    }
}
