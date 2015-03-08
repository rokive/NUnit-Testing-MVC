using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public int Sum(params int[] a)
        {
            int sum = 0;
            foreach(var item in a)
            {
                sum += item;
            }
            return sum;
        }

        public int PositiveSum(int num1, int num2)
        {
            return Math.Abs(num1) + Math.Abs(num2);
        }

        public double SquareRoot(int num)
        {
            return Math.Sqrt(num);
        }

        public IEnumerable<string> OddOrEven(params int[] numList)
        {
            foreach (var item in numList)
            {
                if (item%2==0)
                {
                    yield return "Even";
                }
                else
                {
                    yield return "Odd";
                }
            }
        }
    }
}
