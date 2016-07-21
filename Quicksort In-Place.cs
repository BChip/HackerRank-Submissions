using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        QuickSort(arr, 0, n-1);
    }
    public static void QuickSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int q = Partition(input, left, right);
            Console.WriteLine("{0}", string.Join(" ", input));
            QuickSort(input, left, q - 1);
            QuickSort(input, q + 1, right);
            
        }
    }
    private static int Partition(int[] input, int left, int right)
    {
        int pivot = input[right];
        int temp;

        int i = left;
        for (int j = left; j < right; j++)
        {
            if (input[j] <= pivot)
            {
                temp = input[j];
                input[j] = input[i];
                input[i] = temp;
                i++;
            }
        }
        input[right] = input[i];
        input[i] = pivot;
        return i;
    }
    
}