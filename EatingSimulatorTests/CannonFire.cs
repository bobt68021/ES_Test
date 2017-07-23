using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EatingSimulatorTests.Classes;

namespace EatingSimulatorTests
{
    [TestClass]
    public class CannonFire
    {
        [TestMethod]
        public void TestFire()
        {
            Cannon cannon = new Cannon();
            Assert.AreEqual(1, cannon.Shoot(1));
        }

        [TestMethod]
        public void TestRotate()
        {
        }

        [TestMethod]
        public void TestAngleAdjust()
        {
        }
    }
}
