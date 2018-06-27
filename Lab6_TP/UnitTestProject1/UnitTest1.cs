using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7_TP;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass()]
        public class CalculationsTests
        {
            const float PI = 3.141592654F;
            [TestMethod()]
            //Test 1 for calculating angle in radians for hour hand
            public void HrTest()
            {
                Calculations calc = new Calculations();
                int Hour = 21;
                int Minute = 7;
                float hrRadExpected = 4.77347565F;
                float hrtest = calc.Hr(Hour, Minute, PI);
                Assert.AreEqual(hrRadExpected, hrtest);
            }
            [TestMethod()]
            //Test 2 for calculating angle in radians for hour hand
            public void HrTest1()
            {
                Calculations calc = new Calculations();
                int Hour = 21;
                int Minute = 21;
                float hrRadExpected = 4.89564848F;
                float hrtest = calc.Hr(Hour, Minute, PI);
                Assert.AreEqual(hrRadExpected, hrtest);
            }
            [TestMethod()]
            //Test 1 for calculating angle in radians for minute hand
            public void MinTest()
            {
                Calculations calc = new Calculations();
                int Minute = 13;
                float MinRadExpected = 1.36135685F;
                float mintest = calc.Min(Minute, PI);
                Assert.AreEqual(MinRadExpected, mintest);
            }
            [TestMethod()]
            //Test 2 for calculating angle in radians for minute hand
            public void MinTest1()
            {
                Calculations calc = new Calculations();
                int Minute = 21;
                float MinRadExpected = 2.1991148F;
                float mintest = calc.Min(Minute, PI);
                Assert.AreEqual(MinRadExpected, mintest);
            }
            [TestMethod()]
            //Test 1 for calculating angle in radians for seconds hand
            public void SecTest()
            {
                Calculations calc = new Calculations();
                int Second = 25;
                float SecRadExpected = 2.61799383F;
                float sectest = calc.Sec(Second, PI);
                Assert.AreEqual(SecRadExpected, sectest);
            }
            [TestMethod()]
            //Test 2 for calculating angle in radians for seconds hand
            public void SecTest1()
            {
                Calculations calc = new Calculations();
                int Second = 0;
                float SecRadExpected = 0F;
                float sectest = calc.Sec(Second, PI);
                Assert.AreEqual(SecRadExpected, sectest);
            }
        }
    }
}