using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(5);
        stack.Push(10);
        stack.Push(3);
        stack.Push(8);
        stack.Push(1);

        SortStack(stack);

        Console.WriteLine("Sorted stack:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }

    public static void SortStack(Stack<int> stack)
    {
        Stack<int> tempStack = new Stack<int>();

        while (stack.Count > 0)
        {
            int current = stack.Pop();

            while (tempStack.Count > 0 && tempStack.Peek() > current)
            {
                stack.Push(tempStack.Pop());
            }

            tempStack.Push(current);
        }

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }
}
