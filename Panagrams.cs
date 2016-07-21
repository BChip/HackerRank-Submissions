using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        String c = Console.ReadLine();
        c = c.ToLower();
        char[] noDuplicates = c.Distinct().ToArray();
        if((noDuplicates.Length-1) == 26){
            Console.Write("pangram");
        }
        else{
            Console.Write("not pangram");
        }
    }
}