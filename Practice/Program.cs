using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GetEvenCount(new int[] { 555, 901, 482, 1771 });
            //SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            //CanPermutePalindrome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc");
            //CanFormArray(new int[] { 91, 4, 64, 78, 12, 45, 11, 2}, new int[][] { new int[] { 78, 12 }, new int[] { 91, 4,64 }, new int[] {2 }, new int[] { 45, 11 } });
            //DuplicateZeros(new int[] { 8, 4, 5, 0, 0, 0, 0, 7 });
            //RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            //Sorting.SelectionSort(new int[] { 64, 25, 12, 22, 11 });
            //Sorting.BubleSort(new int[] { 64, 25, 12, 22, 11 });
            Sorting.InsertionSort(new int[] { 64, 25, 12, 22, 11 });

        }

        public static int GetEvenCount(int[] nums)
        {
            int count = 0;
            int numCount = 0;

            if (nums.Length == 0)
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                while (n > 0)
                {
                    n /= 10;
                    numCount++;
                }
                if (numCount % 2 == 0)
                    count++;
                numCount = 0;
            }
            return count;
        }

        public static int[] SortedSquares(int[] nums)
        {
            int[] outArr = new int[nums.Length];
            int start = 0;
            int end = nums.Length - 1;
            int pointer = nums.Length - 1;

            while (start <= end)
            {
                int sq1 = nums[start] * nums[start];
                int sq2 = nums[end] * nums[end];

                if (sq1 > sq2)
                {
                    outArr[pointer] = sq1;
                    pointer--;
                    start++;
                }
                else
                {
                    outArr[pointer] = sq2;
                    pointer--;
                    end--;
                }
            }
            return outArr;
        }

        public static bool CanPermutePalindrome(string s)
        {
            if (s.Length == 1)
                return true;
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                {
                    charCount[s[i]]++;
                }
                else
                {
                    charCount.Add(s[i], 1);
                }
            }

            int oddCount = 0;

            foreach (var count in charCount)
            {
                if (count.Value % 2 != 0)
                    oddCount++;
            }
            return oddCount == 0 || oddCount == 1;
        }

        public static bool CanFormArray(int[] arr, int[][] pieces)
        {
            int n = arr.Length;
            var dict = new Dictionary<int, int[]>();

            foreach (var p in pieces)
            {
                dict.Add(p[0], p);
            }

            int i = 0;
            while (i < n)
            {
                if (!dict.ContainsKey(arr[i]))
                    return false;

                int[] targetPiece = dict[arr[i]];
                foreach (var p in targetPiece)
                {
                    if (p != arr[i])
                        return false;
                    i++;
                }
            }

            return true;
        }
        public static void DuplicateZeros(int[] arr)
        {

            int possibleDups = 0;
            int length_ = arr.Length - 1;

            // Find the number of zeros to be duplicated
            // Stopping when left points beyond the last element in the original array
            // which would be part of the modified array
            for (int left = 0; left <= length_ - possibleDups; left++)
            {

                // Count the zeros
                if (arr[left] == 0)
                {

                    // Edge case: This zero can't be duplicated. We have no more space,
                    // as left is pointing to the last element which could be included  
                    if (left == length_ - possibleDups)
                    {
                        // For this zero we just copy it without duplication.
                        arr[length_] = 0;
                        length_ -= 1;
                        break;
                    }
                    possibleDups++;
                }
            }

            // Start backwards from the last element which would be part of new array.
            int last = length_ - possibleDups;

            // Copy zero twice, and non zero once.
            for (int i = last; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr[i + possibleDups] = 0;
                    possibleDups--;
                    arr[i + possibleDups] = 0;
                }
                else
                {
                    arr[i + possibleDups] = arr[i];
                }
            }
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int valIdx = -1;
            int nonValCount = 0;
            int len = nums.Length;
            int i = 0;

            while (i < len)
            {
                if (nums[i] != val)
                    nonValCount++;

                if (nums[i] == val && valIdx == -1)
                    valIdx = i;
                else if (nums[i] != val && valIdx != -1)
                {
                    int temp = nums[i];
                    nums[i] = nums[valIdx];
                    nums[valIdx] = temp;
                    valIdx++;
                }
                i++;
            }
            return nonValCount;
        }


    }
}
