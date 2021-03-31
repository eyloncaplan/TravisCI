using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Caplan()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Caplan()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Caplan()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        //Multiplication tests
        [Test]
        public void Multiply_Valid_Caplan()
        {
            Assert.AreEqual(24, Program.Multiply("6", "4"));
            Assert.AreEqual(69, Program.Multiply("3", "23"));
            Assert.AreEqual(12, Program.Multiply("3", "4"));
        }

        [Test]
        public void Multiply_Invalid_Caplan()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null_Caplan()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        //Subtraction tests
        [Test]
        public void Subtract_Valid_Caplan()
        {
            Assert.AreEqual(12, Program.Subtract("23", "11"));
            Assert.AreEqual(-2, Program.Subtract("8", "10"));
            Assert.AreEqual(1, Program.Subtract("123", "122"));
        }

        [Test]
        public void Subtract_Invalid_Caplan()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_Caplan()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        //Division tests
        [Test]
        public void Divide_Valid_Caplan()
        {
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(157, Program.Divide("314", "2"));
            Assert.AreEqual(1.1, Program.Divide("1.1", "1"));
        }

        [Test]
        public void Divide_Invalid_Caplan()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_Caplan()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        //Power tests
        [Test]
        public void Power_Valid_Caplan()
        {
            Assert.AreEqual(101, Program.Power("10", "2"));
            Assert.AreEqual(64, Program.Power("4", "3"));
            Assert.AreEqual(1, Program.Power("1.1", "0"));
        }

        [Test]
        public void Power_Invalid_Caplan()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Caplan()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
