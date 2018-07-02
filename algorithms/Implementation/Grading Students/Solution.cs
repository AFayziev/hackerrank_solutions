using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        /*
         * Write your code here.
         */
        int[] result = new int[grades.Length];
        
        for(int i=0; i < grades.Length; i++)
        {
            int grade = grades[i];
            
            if(grade < 38)
            {
                result[i] = grade; // as it is
            }
            else
            {
                // 5 - (grade % 5) is the number
                // we have to add so that result 
                // is divisible by 5 
                int diff = 5 - grade % 5;
                
                if(diff < 3)
                {
                    result[i] = grade + diff;
                }
                else
                {
                    result[i] = grade;
                }
            }
        }
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
