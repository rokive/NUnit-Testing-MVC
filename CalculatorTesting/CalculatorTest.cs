using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Calculator;
using System.Linq;
namespace CalculatorTesting
{
    [TestClass]
    public class CalculatorTest
    {
        Calculation calculation = new Calculation();
        [TestMethod]
        public void Sum()
        {
            int[] Number = new int[] { 1, 2, 3, 4, 5 };
            
            int result = calculation.Sum(Number);
            
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void NotNull()
        {
            var result = calculation.Sum();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostiveNumber()
        {
            int a = -3,b=3;

            int positiveNumber = calculation.PositiveSum(a,b);

            Assert.AreEqual(6, positiveNumber);
        }
        
        [TestMethod]
        public void DecimalNumber()
        {
            double squrNumber = 1.75;

            var result= calculation.SquareRoot(3);

            Assert.AreEqual(squrNumber, result, .02);
        }

        [TestMethod]
        public void OddOrEven()
        {
            int[] number=new int[10];
            for (int i = 0; i <10; i++)
            {
                number[i] = i;
            }

            Assert.AreSame("Even", calculation.OddOrEven(number).First());

            Assert.AreEqual("Odd", calculation.OddOrEven(number).Skip(1).First());
        }
        
    }
}
