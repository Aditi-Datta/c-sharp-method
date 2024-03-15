// See https://aka.ms/new-console-template for more information

using System;
using System.Net;
class Test
{

// method
public static void Message (string text)
{
        Console.WriteLine(text);
}

public static void Add (int number1, int number2){
        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
}

public static void Sub (int number1, int number2){
        int result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");
}

public static int Square (int number){
        return number * number;
}

 public static void Main(string[] args)
    {
        Message("Welcome CSharp");
        Add(50,89);
        Sub(7, 9);
        
        int result = Square(9);
        Console.WriteLine(result);
         }
}

