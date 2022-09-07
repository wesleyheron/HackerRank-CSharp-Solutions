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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {        

        for (int i = 1; i <= n; i++)
        {
            string spacePattern = string.Empty;

            for (int j = 0; j < n - i; j++)
                spacePattern += " ";

            Console.WriteLine(string.Format("{0}{1}", spacePattern, string.Join("", Enumerable.Repeat("#", i).Where(c => c == "#"))));
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
