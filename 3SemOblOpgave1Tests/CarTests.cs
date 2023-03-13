using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3SemOblOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SemOblOpgave1.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car(1, "Audi", 100000, "AB12345");
        Car carWithInvalidModel = new Car(1, "A", 100000, "AB12345");
        Car carWithInvalidPrice = new Car(1, "Audi", -1, "AB12345");
        Car carWithInvalidLicensePlate = new Car(1, "Audi", 100000, "A");
        Car carWithNullModel = new Car(1, null, 100000, "AB12345");
        Car carWithNullPrice = new Car(1, "Audi", null, "AB12345");
        Car carWithNullLicensePlate = new Car(1, "Audi", 100000, null);

        [TestInitialize]
        public void Initialize()
        {
            car.Validate();
        }
        
        [TestMethod()]
        public void ValidateTest()
        {
            Assert.ThrowsException<ArgumentException>(() => carWithInvalidModel.Validate());
            Assert.ThrowsException<ArgumentException>(() => carWithInvalidPrice.Validate());
            Assert.ThrowsException<ArgumentException>(() => carWithInvalidLicensePlate.Validate());
            Assert.ThrowsException<ArgumentNullException>(() => carWithNullModel.Validate());
            Assert.ThrowsException<ArgumentNullException>(() => carWithNullPrice.Validate());
            Assert.ThrowsException<ArgumentNullException>(() => carWithNullLicensePlate.Validate());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("1. Audi, 100000 kr, AB12345", car.ToString());
        }
    }
}