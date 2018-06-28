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

    // Complete the solve function below.
    static int solve(int[] chocNumbers, int day, int month) {
        if(month > chocNumbers.Length)
            return 0;
        
        // segment length -> month
        // segment sum -> day
        int numberOfWays = 0;
        
        int sum = 0;
        
        // get the first sum
        for(int i = 0; i < month; i++) {
            sum += chocNumbers[i];
        }
        
        // once we got the first sum,
        // we start going through the numbers 
        // starting from index = 1
        // on each index i, the current sum would be:
        // sum - numbers [i - 1] /* previous number */ + numbers[i + month - 1]
        // so the general idea on each pass is to deduct one number and add one number
        
        if(sum == day)
            numberOfWays++;
        
        for(int i = 1; i <= chocNumbers.Length - month; i++) {
            sum = sum - chocNumbers[i - 1] + chocNumbers[i + month - 1];
            
            if(sum == day)
                numberOfWays++;
        }
        
        return numberOfWays;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp))
        ;
        string[] dm = Console.ReadLine().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = solve(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
