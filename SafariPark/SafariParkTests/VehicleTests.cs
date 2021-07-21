using SafariParkApp;
using NUnit.Framework;
using System;
namespace SafariParkTests
{
    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenNegativePassengerIsPassedIn_ThrowsException()
        {
            Vehicle v = new Vehicle(5, 40);
            Assert.That(() => v.NumPassengers =-1, Throws.InstanceOf<ArgumentException>());
        }
    }
}
