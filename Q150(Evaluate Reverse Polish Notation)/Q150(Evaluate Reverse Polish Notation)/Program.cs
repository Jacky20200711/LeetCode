using System;
using System.Collections.Generic;
using System.Linq;

namespace Q150_Evaluate_Reverse_Polish_Notation_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int EvalRPN(string[] tokens)
        {
            Stack<int> numbers = new Stack<int>();

            foreach(string token in tokens)
            {
                if(token == "+")
                {
                    int topNum1 = numbers.Pop();
                    int topNum2 = numbers.Pop();
                    numbers.Push(topNum1 + topNum2);
                }
                else if (token == "-")
                {
                    int topNum1 = numbers.Pop();
                    int topNum2 = numbers.Pop();
                    numbers.Push(topNum2 - topNum1);
                }
                else if (token == "*")
                {
                    int topNum1 = numbers.Pop();
                    int topNum2 = numbers.Pop();
                    numbers.Push(topNum2 * topNum1);
                }
                else if (token == "/")
                {
                    int topNum1 = numbers.Pop();
                    int topNum2 = numbers.Pop();
                    numbers.Push(topNum2 / topNum1);
                }
                else
                {
                    numbers.Push(int.Parse(token));
                }
            }
            return numbers.Pop();
        }
    }
}
