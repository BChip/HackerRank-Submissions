using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int count = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        for(int x=0; x<n; x++){
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            for(int y=0; y<arr.Length-1; y++){
                if(arr[y]  == 'A' && arr[y+1] == 'A'){
                    count = count + 1;
                }
                else if(arr[y]  == 'B' && arr[y+1] == 'B'){
                    count = count + 1;   
                }
                else{
                    continue;
                }
            }
            Console.WriteLine(count);
            count = 0;
        }
        
    }
}