using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD01;

public class Calculator
{
    public static void Calculate()
    {
        Console.WriteLine("Enter the first number");
        var number1 = Console.ReadLine();

        Console.WriteLine("Enter the operation +, -, *, /");
        var operation = Console.ReadLine();


        Console.WriteLine("Enter the second number");
        var number2 = Console.ReadLine();

        if (string.IsNullOrEmpty(number1) || string.IsNullOrEmpty(number2) || string.IsNullOrEmpty(operation))
        {
            Console.WriteLine("One of the inputs is null!");
            throw new Exception("One of the inputs is null!");
        }

        var res = DoCalc(number1, number2, operation);

        Console.WriteLine($"The result of the calculation is : {res}");
    }

    static int DoCalc(string nb1, string nb2, string operation)
    {
        int nb1Int = Int32.Parse(nb1);
        int nb2Int = Int32.Parse(nb2);

        switch (operation)
        {
            case "+": return nb1Int + nb2Int;
            case "-": return nb1Int - nb2Int;
            case "*": return nb1Int * nb2Int;
            case "/": return nb1Int / nb2Int;
            default:
                return 0;
                break;
        }

    }
}

