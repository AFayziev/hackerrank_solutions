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

namespace Solution {
    class Solution {
                
        static void Main(string[] args) {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            
            string[] nAndK = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nAndK[0]);
            int k = Convert.ToInt32(nAndK[1]);
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int charged = Convert.ToInt32(Console.ReadLine());
            
            // problem solution
            int sum = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];                
            }
            
            int actualCharge = (sum - prices[k]) / 2;
            
            if(actualCharge == charged)
            {
                textWriter.WriteLine("Bon Appetit");
            }
            else
            {
                int diff = charged - actualCharge;
                textWriter.WriteLine(diff.ToString());
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}