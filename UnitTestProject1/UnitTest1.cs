using System;
using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Frescher_CreateOne_ShouldBeOk()
        {
            var f1 = new Fresher();
            Assert.IsNotNull(f1);
        }
        [TestMethod]
        public void Frescher_CreateTwo_ShouldBeOk()
        {
            var f1 = new Fresher();
            var f2 = new Fresher();
            Assert.IsNotNull(f1);
            Assert.IsNotNull(f2);
        }

        [TestMethod]
        public void TechLead_CreateOne_ShouldBeOk()
        {
            var f1 = new TechLead();
            Assert.IsNotNull(f1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TechLead_CreateTwo_ShouldThrowException()
        {
            var t1 = new TechLead();
            var t2 = new TechLead();
        }
        [TestMethod]
        public void ProductManager_CreateOne_ShouldBeOk()
        {
            var f1 = new ProductManager();
            Assert.IsNotNull(f1);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ProductManager_CreateTwo_ShouldThrowException()
        {
            var t1 = new ProductManager();
            var t2 = new ProductManager();
        }

    }
}
