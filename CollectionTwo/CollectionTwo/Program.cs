using System;
using System.Buffers;
using System.Collections.Generic;
using System.Xml;

public class Program
{
    public static List<int> FindThreeNumbersWithSum(int[] arr, int targetSum)
    {
        List<int> result = new List<int>();
        Array.Sort(arr);
        for(int i = 0; i < arr.Length - 2; i++)
        {
            int left = i + 1;
            int right = arr.Length - 1;
            int currentNumber = arr[i];
            while(left < right)
            {
                int currentSum = currentNumber + arr[left] + arr[right];
                if(currentSum == targetSum)
                {
                    result.Add(currentNumber);
                    result.Add(arr[left]);
                    result.Add(arr[right]);
                    return result;
                }
                else if(currentSum < targetSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int targetSum = 10;
        List<int> result = FindThreeNumbersWithSum(arr, targetSum);

        if (result.Count == 3)
        {
            Console.WriteLine("Three count, which sum is equal " + targetSum + ": " + result[0] + ", " + result[1] + ", " + result[2]);
        }
        else
        {
            Console.WriteLine("Three digits were not found"); ;
        }
    }
}
