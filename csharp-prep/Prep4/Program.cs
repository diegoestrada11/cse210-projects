using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        int numbersList = -1;

        while (numbersList != 0)
        {
            Console.Write("To be stop, press 0");
            string response = Console.ReadLine();
            numbersList = int.Parse(response);

            if (numbersList != 0)
            {
                numbers.Add(numbersList);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.Write($"The sum is: {sum}");
         float average = ((float)sum) / numbers.Count;
         Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

         foreach (int number in numbers)
         {
            if(number > max){
                max = number;
            }
         }

         Console.Write($"We have foun a new max: {max}");
    }
}