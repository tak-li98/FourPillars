using NUnit.Framework;
using SafariParkApp;
using System;
namespace SafariParkTests
{
    public class PersonTests
    {
        [TestCase("Cathy","French","Cathy French")]
        [TestCase("", "", "")]
        public void GivenAPerson_GetFullName_ReturnsCorrectName(string fName, string lName,string expResult)
        {
            // arrange
            var subject = new Person(fName, lName);
            //act
            var result = subject.FullName;
            //assert
            Assert.That(result, Is.EqualTo(expResult));
        }

        [Test]
        public void WhenTheAgeIsChanged_NewAgeIsCorrect()
        {
            var p = new Person() { Age = 18 };
            p.Age = 23;
            Assert.That(p.Age, Is.EqualTo(23));
        }

        [Test]
        public void WhenNewAgeIsLessThanZero_AnExceptionIsThrown()
        {
            var p = new Person() { Age = 18 };
            Assert.That(() => p.Age = -5, Throws.InstanceOf<ArgumentException>());
        }
    }
}