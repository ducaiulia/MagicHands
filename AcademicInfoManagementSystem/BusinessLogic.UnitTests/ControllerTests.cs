using System;
using BusinessLogic.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.UnitTests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void TestControllerGeneration()
        {
            var instance1 = Controller.Instance;
            var instance2 = Controller.Instance;

            Assert.AreEqual(instance1, instance2);
        }
    }
}
