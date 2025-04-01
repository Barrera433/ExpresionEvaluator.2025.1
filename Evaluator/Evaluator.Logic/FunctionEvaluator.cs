using System.Text;

namespace Evaluator.Logic;

public class FunctionEvaluator
{
    public static double Evalute(string infix)
    {
        var postfix = ToPostfix(infix);
        return Calculate(postfix);
    }

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        var numberBuilder = new StringBuilder();

        foreach (var item in postfix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                numberBuilder.Append(item);
            }
            else if (IsOperator(item) || item == ' ')
            {
                if (numberBuilder.Length > 0)
                {
                    stack.Push(double.Parse(numberBuilder.ToString()));
                    numberBuilder.Clear();
                }

                if (IsOperator(item))
                {
                    var operator2 = stack.Pop();
                    var operator1 = stack.Pop();
                    stack.Push(Result(operator1, item, operator2));
                }
            }
        }

        if (numberBuilder.Length > 0)
        {
            stack.Push(double.Parse(numberBuilder.ToString()));
        }

        return stack.Pop();
    }

    private static double Result(double operator1, char item, double operator2)
    {
        return item switch
        {
            '+' => operator1 + operator2,
            '-' => operator1 - operator2,
            '*' => operator1 * operator2,
            '/' => operator1 / operator2,
            '^' => Math.Pow(operator1, operator2),
            _ => throw new Exception("Invalid expresion"),
        };
    }

    private static string ToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = new StringBuilder();
        var numberBuilder = new StringBuilder();

        foreach (var item in infix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                numberBuilder.Append(item);
            }
            else if (IsOperator(item) || item == ' ' || item == '(' || item == ')')
            {
                if (numberBuilder.Length > 0)
                {
                    postfix.Append(numberBuilder.ToString()).Append(' ');
                    numberBuilder.Clear();
                }

                if (IsOperator(item))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (item == ')')
                        {
                            while (stack.Peek() != '(')
                            {
                                postfix.Append(stack.Pop()).Append(' ');
                            }
                            stack.Pop(); // Quitar el '('
                        }
                        else
                        {
                            if (item == '(')
                            {
                                stack.Push(item);
                            }
                            else if (PriorityExpression(item) > PriorityStack(stack.Peek()))
                            {
                                stack.Push(item);
                            }
                            else
                            {
                                while (stack.Count > 0 && PriorityExpression(item) <= PriorityStack(stack.Peek()))
                                {
                                    postfix.Append(stack.Pop()).Append(' ');
                                }
                                stack.Push(item);
                            }
                        }
                    }
                }
            }
        }

        if (numberBuilder.Length > 0)
        {
            postfix.Append(numberBuilder.ToString()).Append(' ');
        }

        while (stack.Count > 0)
        {
            postfix.Append(stack.Pop()).Append(' ');
        }

        return postfix.ToString().Trim();
    }

    private static int PriorityStack(char item)
    {
        return item switch
        {
            '^' => 3,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 0,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static int PriorityExpression(char item)
    {
        return item switch
        {
            '^' => 4,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 5,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static bool IsOperator(char item) => "()^*/+-".IndexOf(item) >= 0;
}