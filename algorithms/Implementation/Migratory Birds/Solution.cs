using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the migratoryBirds function below.
    static int migratoryBirds(int[] ar) {

        int[] occurrences = new int[5];
        
        for(int i = 0; i < ar.Length; i++)
        {
            occurrences[ar[i] - 1]++; // types are 1-5, indexes are 0-4
        }
        
        // in case we have all occurred the same number of times, 
        // the lowest type is 1 which is index 0
        int maxOccurredType = 0; 
        
        for (int i = 1; i < 5; i++)
        {
            int current = occurrences[i];

            if (current > occurrences[maxOccurredType])
                maxOccurredType = i;
        }

        
        return maxOccurredType + 1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = migratoryBirds(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
