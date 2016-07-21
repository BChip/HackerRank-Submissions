using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    /* Head ends here */
    static int stringReduction (string a) {
        int n = a.Length;

        int As = 0, Bs = 0, Cs = 0;

        for (int i = 0; i < n; i++) {
            int ch = a[i];
            if (ch == 'a') As++;
            if (ch == 'b') Bs++;
            if (ch == 'c') Cs++;
        }

        bool cond = true;

        while (cond) {

            if (As == 0 && Bs == 0) cond = false;
            else if (As == 0 && Cs == 0) cond = false;
            else if (Bs == 0 && Cs == 0) cond = false;


            if (As >= Bs && Bs >= Cs){ As--; Bs--; Cs++;}
            else if (As >= Cs && Cs >= Bs){As--; Cs--; Bs++;} 
            else if (Bs >= As && As >= Cs){Bs--; As--; Cs++;} 
            else if (Bs >= Cs && Cs >= As){Bs--; Cs--; As++;} 
            else if (Cs >= As && As >= Bs){Cs--; As--; Bs++;} 
            else if (Cs >= Bs && Bs >= As){Cs--; Bs--; As++;} 

        }

        return As + Bs + Cs + 1;
        return 0;
    }
    /* Tail starts here */
    static void Main(String[] args) {
        int res;
        int _t_cases = Convert.ToInt32(Console.ReadLine());
        for (int _t_i=0; _t_i<_t_cases; _t_i++) {
            String _a = Console.ReadLine();
            res=stringReduction(_a);
            Console.WriteLine(res);
        }
    }
}