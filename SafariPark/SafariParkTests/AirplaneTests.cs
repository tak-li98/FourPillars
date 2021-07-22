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
        [Test]
        public void WhenAnAirplaneDescendss150Metres_PositionIs350()
        {
            Airplane v = new Airplane(250);
            v.Ascend(150);
            Assert.AreEqual(150, v.Altitude);
        }
        [Test]
        public void WhenAnAirplaneDescendsBelowTheGround_ThrowException()
        {
            Airplane v = new Airplane(250);
            Assert.That(() => v.Descend(10), Throws.InstanceOf<ArgumentException>());
        }
        [Test]
        public void WhenAnAirplaneAscendsAboveKarmanLine_ThrowException()
        {
            Airplane v = new Airplane(250);
            Assert.That(() => v.Descend(100100), Throws.InstanceOf<ArgumentException>());
        }
        [Test]
        public void WhenNegativePassengerIsPassedIn_ThrowsException()
        {
            Airplane v = new Airplane(250);
            Assert.That(() => v.NumPassengers = -1, Throws.InstanceOf<ArgumentException>());
        }
        [Test]
        public void WhenPassengerOverCapacityIsPassedIn_ThrowsException()
        {
            Airplane v = new Airplane(250);
            Assert.That(() => v.NumPassengers = 255, Throws.InstanceOf<ArgumentException>());
        }
    }
}
