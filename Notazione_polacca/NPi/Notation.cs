using System;
namespace NPi
{
	public class Notation
	{
		public Stack<Char> polacco = new Stack<Char>();
		public void Example(Stack<Char> stack)
		{
			stack.Push('1');
            stack.Push('4');
            stack.Push('+');
            stack.Push('2');
            stack.Push('*');
            stack.Push('2');
          
        }
        public void Example1(Stack<Char> stack)
        {
            stack.Push('5');
            stack.Push('+');
            stack.Push('0');
            stack.Push('/');
            stack.Push('*');
            stack.Push('2');
            stack.Push('/');
        }
        public void Example2(Stack<Char> stack)
        {
            stack.Push('8');
            stack.Push('2');
            stack.Push('*');
            stack.Push('5');
            stack.Push('+');
            stack.Push('2');
            stack.Push('9');
            stack.Push('*');
            stack.Push('+');
        }
        public void Example3(Stack<Char> stack)
        { 
            stack.Push('1');
            stack.Push('6');
            stack.Push('+');
            stack.Push('2');
            stack.Push('*');
            stack.Push('6');
            stack.Push('/');
        }
        public void Notate(ref Stack<int> stack)
        {
            bool check;
            int total = 0;
            Example(polacco);
            foreach (var ch in polacco)
            {
                Console.WriteLine(total);
                check = Char.IsNumber(ch);
                if (check == true)
                {
                  Convert.ToInt32(ch);
                    stack.Push(ch);
                    continue;
                }
                
                switch (ch)
                    {
                    case '+':
                        foreach (int N in stack)
                        {
                            total += N;
                            
                        }
                       
                        Console.WriteLine(total);
                        break;
                    case '-':
                        foreach (int N in stack)
                        {
                            total -= N;
                        }
                        Console.WriteLine(total);
                        break;
                    case '*':
                        foreach (int N in stack)
                        {
                            total *= N;
                        }
                        Console.WriteLine(total);

                        break;
                    case '/':
                        foreach (int N in stack)
                        {
                            total /= N;
                        }
                        Console.WriteLine(total);

                        break;
                }
                stack.Push(total);
            }
            Console.WriteLine($"the result is {total}");

        }


    }
}

