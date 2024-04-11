using System;
namespace NPi
{
    public class ARR
    {
        public List<char> Notate = new List<char>();

        public void numbers()
        {
            Notate.Add('2');
            Notate.Add('6');
            Notate.Add('*');
            Notate.Add('4');
            Notate.Add('+');
            Notate.Add('2');
            Notate.Add('/');
        }

        public void note(ref Stack<int> list)
        {
            numbers();
            Stack<int> stack = new Stack<int>();
            try
            {
                foreach (char ch in Notate)
                {
                    if (char.IsDigit(ch))
                    {
                        int num = int.Parse(ch.ToString());
                        stack.Push(num);
                    }
                    else
                    {
                        int operand2 = stack.Pop();
                        int operand1 = stack.Pop();
                        int result = 0;

                        switch (ch)
                        {
                            case '+':
                                result = operand1 + operand2;
                                break;
                            case '-':
                                result = operand1 - operand2;
                                break;
                            case '*':
                                result = operand1 * operand2;
                                break;
                            case '/':
                                if (operand2 != 0)
                                    result = operand1 / operand2;
                                else
                                    throw new DivideByZeroException("Cannot divide by zero.");
                                break;
                            default:
                                throw new ArgumentException($"Invalid operator: {ch}");
                        }

                        stack.Push(result);
                    }
                }

                if (stack.Count == 1)
                {
                    list.Push(stack.Pop());
                }
                else
                {
                    throw new ArgumentException("Invalid expression.");
                }
                foreach (var I in list) Console.WriteLine(I);
            } catch (SystemException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine($"Invalid expression");
            }
        }
    }

}