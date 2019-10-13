using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatternExamples
{
    public class LeetCodeProblems
    {
        public void Run()
        {
            //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] ret = TwoSum(nums, target);

            int[] ret2 = TwoSumHash(nums, target);

            //Given a 32-bit signed integer, reverse the digits of an integer
            //Example: 123 -> 321, -123 -> -321, 120 -> 21
            int rev = Reverse2(123);
            rev = Reverse2(-123);
            rev = Reverse2(120);
        }

        public int[] TwoSum(int[] nums, int target)
        {

            //int[] ret = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }

        public int[] TwoSumHash(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            //Two pass solution
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }

            return null;

        }

        public int Reverse(int x)
        {
            //Get the number of digits in int
            
            //Convert to string and put each digit in an array/list
            string str = Convert.ToString(Math.Abs(x));
            var arrStr = str.ToCharArray();
            Array.Reverse(arrStr);

            //TODO: Add sign back on

            int rev = Convert.ToInt32(arrStr);

            return rev;
        }

        public int Reverse2(int x)
        {
            long res = 0;

            while(x != 0)
            {
                //x % 10 gets the digit
                // int digit = x % 10;
                //Put it back on the end
                //int temp = res * 10 + digit;

                res = res * 10 + x % 10;
                x = x / 10;
            }

            if (res < Int32.MinValue || res > Int32.MaxValue)
                return 0;
            else
                return Convert.ToInt32(res);
        }
    }
}
