using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length};
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = { number1, number2, number3, number4 };
            return nums.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sides = {sideLength1, sideLength2, sideLength3 };
            int side1 = sides.Min();
            int side3 = sides.Max();
            int side2 = 1;
            if (side1 == 0) { return false; }
            foreach (var side in sides)
            {
                if (side != sides.Min() && side <= side3)
                {
                    side2 = side;
                }
            }

            return Math.Pow(side1, 2) * Math.Pow(side2, 2) == Math.Pow(side3, 2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = objs.Where(x => x == null);
            return nulls.Count() > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            var nums = numbers.Where(x => x % 2 == 0);
            var avg = nums.Average();
            return (nums == null || !nums.Any()) ? 0 : avg;
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int sum = 1 ;
            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
