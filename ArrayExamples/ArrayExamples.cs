using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatternExamples
{
    public class ArrayExample
    {
        public void Run()
        {
            // Declare a single-dimensional array. 
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // accessing the elements 
            // using for loop 
            Console.Write("For loop :");
            for (int i = 0; i < array2.Length; i++)
                Console.Write(" " + array2[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop 
            foreach (int i in array2)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop 
            int j = 0;
            while (j < array2.Length)
            {
                Console.Write(" " + array2[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop 
            int k = 0;
            do
            {
                Console.Write(" " + array2[k]);
                k++;
            } while (k < array2.Length);

            //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] ret = TwoSum(nums, target);

            int[] ret2 = TwoSumHash(nums, target);

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
            Dictionary<int , int> map = new Dictionary<int, int>();

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
    }
}
