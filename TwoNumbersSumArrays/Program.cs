using System;

namespace TwoNumbersSumArrays
{
    //  Write a function that takes in a non-empty array of distinct integers and an
    //integer representing a target sum.If any two numbers in the input array sum
    //up to the target sum, the function should return them in an array, in any
    //order. If no two numbers sum up to the target sum, the function should return
    //an empty array.

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5 };
            TwoNumSum(arr, 9);
        }

        private static int[] TwoNumSum(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int firstNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];
                    if (firstNum + secondNum == sum)
                    {
                        return new int[] { firstNum, secondNum };
                    }
                }
            }
            return new int[0];



        }
    }
}
