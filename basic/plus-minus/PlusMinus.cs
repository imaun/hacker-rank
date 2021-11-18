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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        NumberFormatInfo precision = new NumberFormatInfo();    
        precision.NumberDecimalDigits = 6;  
        int count = arr.Count;
        int positives = 0;
        int negatives = 0;
        int zeros = 0;

        foreach(var item in arr) {
            if(item > 0)
                positives++;
            else if(item < 0)
                negatives++;
            else
                zeros++;
        }
        
        decimal p = (decimal) positives / count;
        decimal n = (decimal) negatives /count;
        decimal z = (decimal) zeros / count;
        decimal postiveRatio = Math.Round(p, 6);
        decimal negativesRatio = Math.Round(n, 6);
        decimal zerosRatio = Math.Round(z, 6);
        
        Console.WriteLine(postiveRatio.ToString("N", precision));
        Console.WriteLine(negativesRatio.ToString("N", precision));
        Console.WriteLine(zerosRatio.ToString("N", precision));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
        
        Console.ReadLine();
    }
}
