﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab7_TP;

namespace Tests2
{
        public class Tests2
        {

            const float PI = 3.141592654F;
            [Test]
            public void Test1()
            {
                Calculations calc = new Calculations();
                int Hour = 21;
                int Minute = 7;
                float hrRadExpected = 4.77347565F;
                float hrtest = calc.Hr(Hour, Minute, PI);
                Assert.That(hrRadExpected, Is.EqualTo(hrtest));
            }
        [Test]
        public void Test2()
        {
            Calculations calc = new Calculations();
            int Hour = 21;
            int Minute = 21;
            float hrRadExpected = 4.89564848F;
            float hrtest = calc.Hr(Hour, Minute, PI);
            Assert.That(hrRadExpected, Is.EqualTo(hrtest));
        }
        [Test]
        public void Test3()
        {
            Calculations calc = new Calculations();
            int Minute = 13;
            float MinRadExpected = 1.36135685F;
            float mintest = calc.Min(Minute, PI);
            Assert.That(MinRadExpected, Is.EqualTo(mintest));
        }
    }
}
