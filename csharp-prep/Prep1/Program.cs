using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string f_name = Console.ReadLine();
        Console.Write("What is your middle name? ");
        string m_name = Console.ReadLine();

        Console.WriteLine($"I really like your first name {f_name} and your middle name {m_name}.");   
        Console.Write($"{f_name} {m_name} your amazing, have a wonderful day.");    
    }
}