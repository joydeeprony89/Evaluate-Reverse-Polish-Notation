using System;
using System.Collections.Generic;

namespace Evaluate_Reverse_Polish_Notation
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      var tokens = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
      var result =  p.EvalRPN(tokens);
      Console.WriteLine(result);
    }

    public int EvalRPN(string[] tokens)
    {
      Stack<int> stk = new Stack<int>();
      int n1 = 0;
      int n2 = 0;
      foreach (string token in tokens)
      {
        switch (token)
        {
          case "+":
            n2 = stk.Pop();
            n1 = stk.Pop();
            stk.Push(n1 + n2);
            break;
          case "-":
            n2 = stk.Pop();
            n1 = stk.Pop();
            stk.Push(n1 - n2);
            break;
          case "*":
            n2 = stk.Pop();
            n1 = stk.Pop();
            stk.Push(n1 * n2);
            break;
          case "/":
            n2 = stk.Pop();
            n1 = stk.Pop();
            stk.Push(n1 / n2);
            break;
          default:
            int n = Convert.ToInt32(token);
            stk.Push(n);
            break;
        }
      }
      return stk.Peek();
    }
  }
}
