using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using calculator_tp_lab_1;
using ClassLibrary1;

namespace CalcTests
{
    public class Tests
    {
        
        [Test]
        public void Test22()
        {
            Class1 test1 = new Class1();
            char operation_key = '-';
            bool operation_active1 = false;
            bool operation_active2 = true;
            double result = 66.66;
            string textBox1Text = "67";
            double number = 0;
            double expected = -0.34;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            Class1 test1 = new Class1();
            char operation_key = '*';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 2;
            string textBox1Text = "3";
            double number = 0;
            double expected = 6;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 1);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test33()
        {

            Class1 test1 = new Class1();
            char operation_key = '*';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 15;
            string textBox1Text = "-1";
            double number = 0;
            double expected = -15;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 1);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            Class1 test1 = new Class1();
            char operation_key = '/';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = 10.4;
            string textBox1Text = "21,2";
            double number = 2;
            double expected = 5.2;
            test1.Result1(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test44()
        {
            Class1 test1 = new Class1();
            char operation_key = '/';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = -5;
            string textBox1Text = "21.5";
            double number = -1;
            double expected = 5;
            test1.Result1(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5()
        {
            Class1 test1 = new Class1();
            char operation_key = '+';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = 5;
            string textBox1Text = "21.2";
            double number = 2;
            double expected = 7;
            test1.Result(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test6()
        {
            Class1 test1 = new Class1();
            char operation_key = 'c';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 23;
            string textBox1Text = "-2";
            double number = 0;
            double expected = -0.42;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test66()
        {
            Class1 test1 = new Class1();
            char operation_key = 'c';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 23;
            string textBox1Text = "1";
            double number = 0;
            double expected = 0.54;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test7()
        {
            Class1 test1 = new Class1();
            char operation_key = 's';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "1";
            double number = 0;
            double expected = 0.84;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test77()
        {
            Class1 test1 = new Class1();
            char operation_key = 's';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "3";
            double number = 0;
            double expected = 0.14;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test8()
        {
            Class1 test1 = new Class1(); //тест на операцию 1/x
            char operation_key = 'd';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "2";
            double number = 0;
            double expected = 0.5;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test88()
        {
            Class1 test1 = new Class1();
            char operation_key = 'd';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "-2";
            double number = 0;
            double expected = -0.5;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 4);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
