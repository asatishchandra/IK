using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public static class Sorting
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                Swap(i, minIndex, arr);
            }
        }
        //64, 25, 12, 22, 11
        public static void BubleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                        Swap(j - 1, j, arr);
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            //InsertionSortHelper(arr, arr.Length - 1);
            InsertionSortIterativeHelper(arr);
            Console.WriteLine(arr);
        }

        private static void InsertionSortHelper(int[] arr, int n)
        {
            if (n <= 0)
                return;
            
            InsertionSortHelper(arr, n - 1);
            int ele = arr[n];
            int j = n - 1;
            while(j >= 0 && arr[j] > ele)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = ele;
            return;
        }

        private static void InsertionSortIterativeHelper(int[] arr)
        {
            if (arr.Length <= 0)
                return;

            //InsertionSortHelper(arr, n - 1);
            for(int i = 1; i < arr.Length; i++)
            {
                int ele = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > ele)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = ele;
            }
            
            return;
        }


        private static void Swap(int index1, int index2, int[] arr)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
