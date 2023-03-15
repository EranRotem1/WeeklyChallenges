using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int x = startNumber;
            if (x == 0) {return n; }
            while (x % n != 0) 
            {
                x++;
            }
            if (x == startNumber) { return x += n; }
            return x;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                { bus.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) {return false; }
            var numsOrdered = numbers.OrderBy(x => x).ToArray();
            return Enumerable.SequenceEqual(numbers, numsOrdered);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null ) return sum;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (i + 1 <= numbers.Length - 1)
                        sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            var strings = new List<string>();
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word) == false)
                {
                    strings.Add(word.Trim());
                }
            }
            if (string.IsNullOrWhiteSpace(string.Join("", strings))) { return ""; }
            return string.Join(" ", strings) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return Array.Empty<double>();
            var results = new List<double>();
            for (int i = 3; i < elements.Count(); i += 4)
            {
                results.Add(elements[i]);
            }
            return results.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        { 
            if (nums.Length <= 1) { return false; }
            var sums = new List<double>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        sums.Add(nums[i] + nums[j]);
                    }
                }
            }
            return sums.Contains(targetNumber);
        }
    }
}
