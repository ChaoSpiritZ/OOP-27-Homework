using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_27_Homework;

namespace OOP_27_Test
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        [ExpectedException(typeof(CarAlreadyHereException))]
        public void AddCarMethodAlreadyHere()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
            myGarage.AddCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(WeDoNotFixTotalLostException))]
        public void AddCarMethodTotalLost()
        {
            Car car1 = new Car("mazda", true, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongGarageException))]
        public void AddCarMethodWrongGarage()
        {
            Car car1 = new Car("toyota", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void AddCarMethodCarNull()
        {
            Car car1 = null;
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void AddCarMethodRepairMismatch()
        {
            Car car1 = new Car("mazda", false, false);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
        }

        [TestMethod]
        public void AddCarMethod()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
        }

        //-------------------------------------------------------------------------

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void TakeOutCarMethodCarNull()
        {
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.TakeOutCar(null);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TakeOutCarMethodCarNotInGarage()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.TakeOutCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNotReadyException))]
        public void TakeOutCarMethodCarNotReady()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
            myGarage.TakeOutCar(car1);
        }

        [TestMethod]
        public void TakeOutCarMethod()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
            myGarage.FixCar(car1);
            myGarage.TakeOutCar(car1);
            Assert.AreEqual(false, car1.NeedsRepair);
        }

        //--------------------------------------------------------------------------------

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void FixCarMethodCarNull()
        {
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.FixCar(null);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void FixCarMethodCarNotInGarage()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.FixCar(car1);
        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void FixCarMethodRepairMismatch()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
            myGarage.FixCar(car1);
            myGarage.FixCar(car1);
        }

        [TestMethod]
        public void FixCarMethod()
        {
            Car car1 = new Car("mazda", false, true);
            Garage myGarage = new Garage(new List<string>() { "mazda" });
            myGarage.AddCar(car1);
            myGarage.FixCar(car1);
            Assert.AreEqual(false, car1.NeedsRepair);
        }
    }
}
