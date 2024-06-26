using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 93)
        {
            letter = "A";
        }
        if (percent >= 90 && percent <= 92)
        {
            letter = "A-";
        }
        else if (percent >= 87 && percent <= 89)
        {
            letter = "B+";
        }
        else if (percent >= 83 && percent <= 86)
        {
            letter = "B";
        }
        else if (percent >= 80 && percent <= 82)
        {
            letter = "B-";
        }
        else if (percent >= 77 && percent <= 79)
        {
            letter = "C+";
        }
        else if (percent >= 73 && percent <= 76)
        {
            letter = "C";
        }
        else if (percent >= 70 && percent <= 72)
        {
            letter = "C-";
        }
        else if (percent >= 67 && percent <= 69)
        {
            letter = "D+";
        }
        else if (percent >= 63 && percent <= 66)
        {
            letter = "D";
        }
        else if (percent >= 60 && percent <= 62)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}