using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GithubActionsLab
{
    [TestClass]
    public class Addition
    {
        [TestMethod]
        public void Add_Valid_Patino()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid_Patino()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null_Patino()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }
    }

    [TestClass]
    public class Subtraction
    {
        [TestMethod]
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-2, Program.Subtract("5", "7"));
        }

        [TestMethod]
        public void Subtract_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
        }

        [TestMethod]
        public void Subtract_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
        }
    }

    [TestClass]
    public class Multiplication
    {
        [TestMethod]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("5", "7"));
        }

        [TestMethod]
        public void Multiply_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
        }

        [TestMethod]
        public void Multiply_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
        }
    }

    [TestClass]
    public class Division
    {
        [TestMethod]
        public void Divide_Valid()
        {
            Assert.AreEqual(0.5, Program.Divide("1", "2"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
            Assert.AreEqual(5.0 / 7.0, Program.Divide("5", "7"));
            Assert.IsTrue(double.IsInfinity(Program.Divide("1", "0")));
        }

        [TestMethod]
        public void Divide_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
        }

        [TestMethod]
        public void Divide_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
        }
    }

    [TestClass]
    public class Exponentiation
    {
        [TestMethod]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(25, Program.Power("5", "2"));
        }

        [TestMethod]
        public void Power_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Power("2", "b"));
            Assert.ThrowsException<FormatException>(() => Program.Power("c", "3"));
            Assert.ThrowsException<FormatException>(() => Program.Power("uwu", "rawr"));
        }

        [TestMethod]
        public void Power_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "3"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
        }

        [TestMethod]
        public void Power_Intentional_Fail_For_CI()
        {
            Assert.AreEqual(10, Program.Power("2", "3"));
        }
    }
}
