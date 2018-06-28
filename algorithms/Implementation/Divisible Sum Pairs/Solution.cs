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

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int divideBy, int[] numbers) {
        // The brute-force approach is to use nested loop,
        // which gives O(n^2) runtime. Can we do better?
        // Well, I guess the problem statement itself hints
        // using nested loop (i and j)
        
        int totalPairs = 0;

        for(int i = 0; i < n; i++) 
        {
            for(int j = i + 1; j < n; j++) {
                int sum = numbers[i] + numbers[j];
                
                if(sum % divideBy == 0)
                    totalPairs++;
            }
        }
        
        return totalPairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
