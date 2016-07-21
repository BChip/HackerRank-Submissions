using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(n.ToString().ToArray(), x=>(int)x - 48);
            for(int x=0; x<=arr.Length-1; x++){
                if(arr[x] != 0 && n % arr[x] == 0){
                    count = count + 1;
                }   
            }
            Console.WriteLine(count);
            count = 0;
        }
    }
}