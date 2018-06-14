using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int positiveCount = 0, negativeCount = 0, zeroCount = 0;

        for(int i = 0; i < n; i++) {
            var val = arr[i];
            
            if(val > 0) {
                positiveCount++;
            }
            else if(val < 0) {
                negativeCount++;
            }
            else if(val == 0) {
                zeroCount++;
            }
        }
        
        decimal positiveFraction = (decimal)positiveCount / n;
        decimal negativeFraction = (decimal)negativeCount / n;
        decimal zeroFraction = (decimal)zeroCount / n;

        Console.WriteLine(positiveFraction.ToString("N6"));
        Console.WriteLine(negativeFraction.ToString("N6"));
        Console.WriteLine(zeroFraction.ToString("N6"));
    }
}
