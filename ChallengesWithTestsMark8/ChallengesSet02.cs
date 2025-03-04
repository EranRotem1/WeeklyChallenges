﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null ) return 0;
            else if (numbers.Sum() != 0)
            { return numbers.Max() + numbers.Min(); }
            else { return 0; }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            int total = 0;
            foreach (int number in numbers) 
            {
                total += (number % 2 == 0) ? number : 0;
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
                return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddsNum = 0;
            for (int i = 0; i < number; i++) 
            {
                if (i > 0 && i % 2 != 0)
                {
                    oddsNum++;
                }
            }
            return oddsNum;
        }
    }
}
