using System;
using System.Collections.Generic;



public class MainClass
{

    private static void Main()
    {
        Calculator.Add(10, 50);
    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> Numbers) Method")]
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    #region Add
    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum += Number;
        }
        return Sum;
    }
    #endregion
}


