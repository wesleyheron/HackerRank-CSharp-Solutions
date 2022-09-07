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

        List<long> sumArr = new()
        {
            arr.Sum(c => (long)c) - arr[0],
            arr.Sum(c => (long)c) - arr[1],
            arr.Sum(c => (long)c) - arr[2],
            arr.Sum(c => (long)c) - arr[3],
            arr.Sum(c => (long)c) - arr[4]
        };

        Console.Write(sumArr.Min(x => x));
        Console.Write(" ");
        Console.Write(sumArr.Max(x => x));
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
