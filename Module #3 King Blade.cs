using System;

public class Program
{
    public static void Main()
    {
        int i = 3;
        object boxed = i;
        Console.WriteLine(boxed);
        Stack<string> stack = new Stack<string>();
        stack.Push("sausage");
        string s = (string)stack.Pop();
        Console.WriteLine(s);
    }
}

public class Stack
{
    int position;
    object[] data = new object [10];
    public void Push(object obj) { data[position++] = obj; }
    public object Pop() { return data[--position]; }
}