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

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var timePortion = s.Substring(0, s.Length -2);
        var hour = timePortion.Substring(0, 2);
        int hourValue = int.Parse(hour);
        bool isAM = s.LastIndexOf("AM") > 0;
        bool isPM = s.LastIndexOf("PM") > 0;
        var timeWithoutHour = timePortion.Substring(2, timePortion.Length-2);

        if(isAM && hourValue == 12) {
            hourValue = 0;
        }
        else if(isPM && hourValue == 12) {
            return timePortion;
        }
        else if(isPM && hourValue < 12){
            hourValue+= 12;
        }
        
        return $"{hourValue.ToString().PadLeft(2, '0')}{timeWithoutHour}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
