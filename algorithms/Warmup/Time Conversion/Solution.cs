using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        // 12:00:00PM
        var amPmPart = s.Substring(8);
        var hourPart = s.Substring(0, 2);
        var minsAndSecs = s.Substring(3, 5);
        string militaryHourPart = "";
        
        if(amPmPart == "AM" && hourPart == "12") {
            militaryHourPart = "00";
        }
        else if(amPmPart == "PM" && int.Parse(hourPart) < 12) {
            militaryHourPart = (int.Parse(hourPart) + 12).ToString();
        }
        else {
            militaryHourPart = hourPart;
        }
        
        return militaryHourPart + ":" + minsAndSecs;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
