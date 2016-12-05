using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System.Threading;

namespace SingletonUnitTests
{
    [TestClass]
    public class SingetonTests
    {
        private string test1;
        private string test2;
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void TestMethod1()
        {
           
            testContextInstance.WriteLine("Hello");

            MyfabClass myfabc = MyfabClass.GiveMeInstance();
            test1 = myfabc.identifier;
           
            testContextInstance.WriteLine($"Identifier{myfabc.identifier}");

            new Thread(() =>
            {
                myfabc = MyfabClass.GiveMeInstance();
                
                testContextInstance.WriteLine($"Identifier{myfabc.identifier}");
            });

            new Thread(() =>
                 {
             myfabc = MyfabClass.GiveMeInstance();
               
                testContextInstance.WriteLine($"Identifier{myfabc.identifier}");
                       });

        }

        [TestMethod]
        public void TestMethod2 ()
        {

            MyfabClass myfabc = MyfabClass.GiveMeInstance();          
            testContextInstance.WriteLine($"Identifier{myfabc.identifier}");
            test2 = myfabc.identifier;

            Assert.AreNotEqual(test1, test2);
        }
            
            }
}
