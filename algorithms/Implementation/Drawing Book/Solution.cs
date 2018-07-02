using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int totalPages, int p) {
        /*
         * Write your code here.
         */
        
        // edge cases
        if(totalPages == p || p == 1)
            return 0;
        
        // odd number of pages and 
        // page number is at the end
        if(totalPages % 2 != 0 && totalPages - p <= 1)
            return 0;
        
        // check which way to turn
        int middle = totalPages / 2;
        int turns = 0;
        
        if(p <= middle)
        {
            // turn from start
            turns = p / 2;
        }
        else
        {
            // turn from end
            if(totalPages % 2 == 0)
            {
                turns = (totalPages - p + 1) / 2;
            }
            else
            {
                turns = (totalPages - p) / 2;
            }
        }
        
        return turns;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
