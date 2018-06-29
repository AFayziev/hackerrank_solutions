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
    static string solve(int year) {
        // the 256th day of year will always be the on September
        // the exact day will depend on whether is is leap year or not
        // i.e Leap year -> Sep 12th vs Non leap year -> Sep 13th 

        int day = 0;
        int month = 9;
        
        if (year < 1918) {
            // check Julian leap year 
            bool isLeap = year % 4 == 0;
            day = isLeap ? 12 : 13;
        }
        else if(year == 1918)
        {
            // special case when Feb 14 is 32nd day of year
            // Non leap ie Sep 13th + shift forward by 13 days
            day = 13 + 13; 
        }
        else if(year > 1918)
        {
            // check Gregorian leap year
            bool isLeap = (year % 400 == 0) 
                || (year % 4 == 0 && year % 100 != 0);
            day = isLeap ? 12 : 13;
        }
        
        string dayString = day < 10 ? "0" + day.ToString() : day.ToString();
        string monthString = month < 10 ? "0" + month.ToString() : month.ToString();
        
        return dayString + "." + monthString + "." + year.ToString();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine());

        string result = solve(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
