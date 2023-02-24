using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Where(x => x % 2 != 0).Count() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool num = false;
            for (int  i = 0; i < password.Length; i++) 
            {
                if (Char.IsLetter(password[i]))
                {
                    if (Char.IsUpper(password[i])) { upper = true; }
                    else { lower = true; }
                }
                else if (Char.IsNumber(password[i])) 
                {
                    num= true;
                }
            }
            return upper == true && lower == true && num == true;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor== 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> arr = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                arr.Add(i);
            }
            return arr.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
