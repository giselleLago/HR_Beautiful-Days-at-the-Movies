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

class Solution
{

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k)
    {
        var rang = (j - i) + 1;
        
        var contInt = 0;
        IEnumerable<int> numbers = Enumerable.Range(i, rang);
        foreach (int n in numbers)
        {
            var num = n.ToString();

            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            var newString = new string (charArray);
            var rev = Convert.ToInt32(newString);

            var resFinal = (n - rev) / k;
            if ((n - rev) % k == 0) 
            {
                contInt++;
            }
        }
        return contInt;


    }

    static void Main(string[] args)
    {

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}

