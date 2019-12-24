using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new ClassLibrary1.Math();
            //var test = math.SquareRoot(64);

            var assembly = Assembly.LoadFrom("ClassLibrary1.dll");
            var type = assembly.GetType("ClassLibrary1.Math");
            //var method = type.GetMethod("SquareRoot"); //, 
            //    BindingFlags.NonPublic | BindingFlags.Instance);
            var ctr = type.GetConstructor(new Type[0]);
            var inst = ctr.Invoke(new Object[0]);

            double outcome = -1;
            foreach (var method in type.GetMethods())
            {
                if (method.Name == "SquareRoot")
                {
                    var result = method.Invoke(inst, new object[1] { 64});
                    outcome = (double)result;
                }
            }

            //ClassLibrary1.Math.MathHelper 
            Assert.AreEqual(outcome, 8);
        }
    }
}
