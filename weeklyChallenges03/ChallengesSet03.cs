using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges03
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) => vals.Contains(false);

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsupper = false;
            bool containslower = false;
            bool containsnumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    containsupper = true;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    containslower = true;
                }
            }
            foreach (char num in password)
            {
                if (char.IsDigit(num))
                {
                    containsnumber = true;
                }
            }

            if (containsnumber == true && containslower == true && containsupper == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
            {
                return 0;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums[nums.Length - 1];
            return last - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> number = new List<int>();
            int[] odds;
            odds = new int[49];

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    number.Add(i);
                }
            }

            int[] Oddsbelow100 = number.ToArray();

            return Oddsbelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int sum = 0;
            foreach (string count in words)
            {
                sum++;
            }

            for (int i = 0; i < sum; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }

    }
}
