using System;
using System.Collections.Generic;
using System.Text;

class E07CalculationOfArithmeticExpression
{

    static void Main ()
    {
        // Write a program that calculates the value of given arithmetical expression. The expression can contain 
        // the following elements only:
        // Real numbers, e.g. 5, 18.33, 3.14159, 12.6
        // Arithmetic operators: +, -, *, / (standard priorities)
        // Mathematical functions: ln(x), sqrt(x), pow(x,y)
        // Brackets (for changing the default priorities)
        // Examples:
        // (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) + Pow(2, 3.14) * (3 - (3 * sqrt(2) - -3.2) + 1.5*0.3) 
        // Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".


        // Само съм разучавал "стек" и "опашка"

        string arithmeticalExpression = Console.ReadLine ();

       
        ArithmeticExpression.Calculate (arithmeticalExpression);
        
    }
}




class ArithmeticExpression
{
    private static readonly string[] operators = { "/", "*", "+", "-" };

    private static Queue<string> queue = new Queue<string> ();

    private static Stack<string> stack = new Stack<string> ();






    public static string Calculate (string arithmeticalExpression)
    {
        string result = string.Empty;

        RPN (arithmeticalExpression);



        return result;
    }


    private static void RPN (string ArithmeticExpression)
    {
        string[] members = SplitArithmeticalExpression (ArithmeticExpression);

        string temp;

                
        for (int index = 0; index < members.Length; index++)
        {
            double doubleNumber = 0;

            if (members[index] == string.Empty)
            {
                continue;
            }
            if (double.TryParse (members[index], out doubleNumber))
            {
                queue.Enqueue (Convert.ToString (doubleNumber));
            }
            else if (IsFunction (members[index]))
            {
                stack.Push (members[index]);
            }
            else if (members[index] == ",")
            {
                if (stack.Contains ("(") && stack.Count != 0)
                {
                    while (stack.Peek () != "(")
                    {
                        temp = stack.Pop ();
                        queue.Enqueue (temp);                        
                    }
                }
                else
                {
                    Console.WriteLine ("Separator ',' was misplaced or parentheses () were mismatched");
                    return;
                }
            }
            else if (IsOperator (members[index]))
            {
                if (stack.Count != 0)
                {
                    string currentOperator = stack.Peek ().ToString ();

                    int firstOperatorPriority = GetPriority (members[index]);

                    int secondOperatorPriority = GetPriority (stack.Peek ().ToString ());

                    bool isTrue = (IsOperator (currentOperator)) && (firstOperatorPriority <= secondOperatorPriority);

                    while (isTrue && stack.Count != 0)
                    {
                        temp = stack.Pop ();
                        queue.Enqueue (temp);

                        if (stack.Count == 0)
                        {
                            break;
                        }
                        
                        currentOperator = stack.Peek ().ToString ();

                        firstOperatorPriority = GetPriority (members[index]);

                        secondOperatorPriority = GetPriority (stack.Peek ().ToString ());

                        isTrue = (IsOperator (currentOperator)) && (firstOperatorPriority <= secondOperatorPriority);
                    }
                }
                stack.Push (members[index]);
            }
            else if (members[index] == "(")
            {
                stack.Push ("(");
            }
            else if (members[index] == ")")
            {
                if (stack.Contains ("(") && stack.Count != 0)
                {
                    while (stack.Peek () != "(")
                    {
                        temp = stack.Pop ();
                        queue.Enqueue (temp);                       
                    }
                    if (stack.Count != 0)
                    {
                        temp = stack.Pop ();
                    }

                    if (stack.Count != 0)
                    {
                        while (stack.Peek () == "ln" || stack.Peek () == "sqrt" || stack.Peek () == "pow")
                        {
                            temp = stack.Pop ();
                            queue.Enqueue (temp);                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Parentheses () were mismatched.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }

        while (stack.Count != 0)
        {
            if (stack.Peek () == "(" || stack.Peek () == ")")
            {
                Console.WriteLine("Parentheses () were mismatched.");
                return;
            }
            else
            {
                temp = stack.Pop ();
                queue.Enqueue (temp);
            }
        }
       
    }



    private static int GetPriority (string arithmeticOperator)
    {
        if (arithmeticOperator == "+" || arithmeticOperator == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }


    private static bool IsFunction (string member)
    {
        string[] functions = { "ln", "sqrt", "pow" };

        bool stringIsFunctions = false;

        for (int index = 0; index < functions.Length; index++)
        {
            if (functions[index] == member)
            {
                stringIsFunctions = true;
            }
        }

        return stringIsFunctions;
    }


    private static bool IsOperator (string member)
    {
        bool stringIsOperator = false;

        for (int index = 0; index < operators.Length; index++)
        {
            if (operators[index] == member)
            {
                stringIsOperator = true;
            }
        }

        return stringIsOperator;
    }


    private static string[] SplitArithmeticalExpression (string arithmeticalExpression)
    {
        arithmeticalExpression = arithmeticalExpression.ToLower ();

        StringBuilder tempArithmeticalExpression = new StringBuilder ();


        for (int index = 0; index < arithmeticalExpression.Length; index++)
        {
            if (arithmeticalExpression[index] == '(' || arithmeticalExpression[index] == ')' ||
                arithmeticalExpression[index] == '+' || arithmeticalExpression[index] == '-' ||
                arithmeticalExpression[index] == '*' || arithmeticalExpression[index] == '/' || 
                arithmeticalExpression[index] == ',')
            {
                tempArithmeticalExpression.Append (' ');

                tempArithmeticalExpression.Append (arithmeticalExpression[index]);

                if (arithmeticalExpression[index] != '-')
                {
                    tempArithmeticalExpression.Append (' ');
                }
            }
            else
            {
                tempArithmeticalExpression.Append (arithmeticalExpression[index]);
            }
        }

        string newArithmeticalExpression = Convert.ToString (tempArithmeticalExpression);

        string[] members = newArithmeticalExpression.Split (' ');

        return members;
    }
}












//switch (members[index])
//                {
//                    case "ln":
//                        {
//                            int count = 0;

//                            for (index++; members[index] != ")" || count < 1; index++)
//                            {
//                                if (double.TryParse (members[index], out doubleNumber))
//                                {
//                                    count++;
//                                }
//                            }

//                            if (count == 1 && doubleNumber >= 0)
//                            {
//                                stack.Push (Convert.ToString (Math.Log (doubleNumber)));
//                            }
//                        }
//                        break;
//                    case "sqrt":
//                        {
//                            int count = 0;

//                            for (index++; members[index] != ")" || count < 1; index++)
//                            {
//                                if (double.TryParse (members[index], out doubleNumber))
//                                {
//                                    count++;
//                                }
//                            }

//                            if (count == 1 && doubleNumber >= 0)
//                            {
//                                stack.Push (Convert.ToString (Math.Sqrt (doubleNumber)));
//                            }
//                        }
//                        break;
//                    case "pow":
//                        {                            
//                            int count = 0;
//                            double value = 0;
//                            double level = 0;

//                            for (index++; members[index] != ")" || count < 2; index++)
//                            {
//                                if (double.TryParse (members[index], out doubleNumber))
//                                {                                    
//                                    count++;
//                                    if (count == 1)
//                                    {
//                                        value = doubleNumber;
//                                    }
//                                    if (count == 2)
//                                    {
//                                        level = doubleNumber;
//                                    }
//                                }
//                            }

//                            if (count == 2)
//                            {
//                                stack.Push (Convert.ToString (Math.Pow (value, level)));                                
//                            }
//                        }
//                        break;
//                }
