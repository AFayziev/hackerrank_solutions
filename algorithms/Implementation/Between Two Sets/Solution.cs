using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        /*
         * Write your code here.
         */
        int result = 0;
        // consider only the numbers which are 
        // between a's max and b's min
        int maxOfA = a.Max();
        int minOfB = b.Min();

        for(int i = maxOfA; i <= minOfB; i += maxOfA) { // increment by maxOfA so that new number also divides by maxOfA
            bool factorOfA = true;
            foreach(int number in a) {
                if(i % number == 0) {
                    continue;                    
                }    
                else {
                    factorOfA = false;
                    break;
                }
            }

            bool factorOfB = true;
            foreach(int number in b) {
                if(number % i == 0) {
                    continue;
                }
                else{
                    factorOfB = false;
                    break;
                }
            }

            if(factorOfA && factorOfB) {
                result++;
            }
        }
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
