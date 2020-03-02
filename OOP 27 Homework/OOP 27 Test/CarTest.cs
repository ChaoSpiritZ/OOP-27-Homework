using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_27_Homework;

namespace OOP_27_Test
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void CarConstructor()
        {
            Car car = new Car("toyota", true, false);
        }
    }
}
