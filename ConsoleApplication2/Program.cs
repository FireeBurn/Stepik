using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    public static void Main()
    {   
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(number);        
    }

    static void VasyaStyle(int num)
    {
        List<string> correctNums = new List<string>();
        List<int> allNums = new List<int>();
        allNums.Add(2);
        allNums.Add(3);
        allNums.Add(7);
        var count = 0;

        while (allNums[allNums.Count - 1] < num)
        {
            for (var i = 0; i < 3; i++) 
            {
                allNums.Add(int.Parse($"{allNums[i+count]}" + $"{2}"));
                allNums.Add(int.Parse($"{allNums[i+count]}" + $"{3}"));
                allNums.Add(int.Parse($"{allNums[i+count]}" + $"{7}"));
            }
            count += 3;
        }

        while (allNums[allNums.Count - 1] > num)
        {
            allNums.RemoveAt(allNums.Count - 1);
        }

        
        for (var k = 0; k < allNums.Count; k++)
        {
            var a = num - allNums[k];
            for (var j = 0; j < allNums.Count; j++)
            {
                int b = a / allNums[j];
                if (allNums.Contains(b) && a % allNums[j] == 0)
                {
                    correctNums.Add($"{num} = {allNums[j]} * {b} + {allNums[k]}");
                }
            }
        }
    }
}