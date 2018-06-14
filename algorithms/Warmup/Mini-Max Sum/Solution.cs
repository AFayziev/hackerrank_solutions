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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        int min = int.MaxValue;
        int max = 0;
        long sum = 0;
        
        for(int i = 0; i < arr.Length; i++) {
            sum += arr[i];
            
            if(arr[i] < min) {
                min = arr[i];
            }
            
            if(arr[i] > max) {
                max = arr[i];
            }
        }
        
        Console.WriteLine((sum - max).ToString() + " " + (sum - min).ToString());
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
