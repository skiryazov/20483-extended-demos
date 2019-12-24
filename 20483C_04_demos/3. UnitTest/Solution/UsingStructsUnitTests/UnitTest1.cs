using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UsingStructs;

namespace UsingStructsUnitTests
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void ConstructorUsesDefaultCoffeeNameTest()
        {
            // arrange - nothing to do here

            // act
            Coffee coffee = new Coffee();

            // assert
            Assert.AreEqual("Coffee", coffee.Name);
        }
    }
}
