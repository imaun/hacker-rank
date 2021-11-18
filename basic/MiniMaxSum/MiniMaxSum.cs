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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int count = arr.Count;
        long max = 0;
        long min = 0;
        bool firstRound = true;
        for(int i = 0; i < count; i++) {
            long sum = 0;
            for(int j = 0; j < count; j++) {
                if(j != i)
                    sum += arr[j];
            }
            if(firstRound)
                min = sum;
            if(max < sum)
                max = sum;
            if(min > sum)
                min = sum;
            sum = 0;
            firstRound = false;
        } 

        Console.WriteLine($"{min} {max}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
