using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System.Threading;

namespace SingletonUnitTests
{
    [TestClass]
    public class SingetonTests
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s1;
            string s2;
            testContextInstance.WriteLine("Hello");

            new Thread(() =>

            {
                MyfabClass myfabc;

                myfabc = MyfabClass.GiveMeInstance();
                s1 = myfabc.identifier;
                testContextInstance.WriteLine($"Came to this:{s1}");
                Console.WriteLine(myfabc.identifier);
            }
            );

            new Thread(() =>

            {
                MyfabClass myfabc;

                myfabc = MyfabClass.GiveMeInstance();
                s2 = myfabc.identifier;
                testContextInstance.WriteLine(s2);
                Console.WriteLine(myfabc.identifier);
            }
            );

            //Assert.AreNotEqual(s1, s2);


        }
    }
}
