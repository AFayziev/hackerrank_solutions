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
        // TO DO: we can optimize further by using an array
        // but the runtime and space would still be the same
        // runtime: O(n) 
        // space: O(1)
        Dictionary<int, int> occurrences = new Dictionary<int, int>() {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 }
        };
        
        for(int i = 0; i < ar.Length; i++)
        {
            occurrences[ar[i]]++;
        }
        
        int maxOccurredType = 1; // in case we have all 1, the lowest type is 1
        
        for (int i = 2; i <= 5; i++)
        {
            int current = occurrences[i];

            if (current > occurrences[maxOccurredType])
                maxOccurredType = i;
        }
        
        return maxOccurredType;
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
