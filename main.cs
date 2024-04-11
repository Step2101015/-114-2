/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);

        Console.WriteLine($"Количество слов в строке: {wordCount}");
    }

    static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}