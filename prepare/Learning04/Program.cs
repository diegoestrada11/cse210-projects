using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Diego Estrada", "Programming");
        Console.WriteLine(a1.GetSummary());

        MathAssigments m1 = new MathAssigments("201","0.1.2", "Zach Banhart", "Psychology");
        Console.WriteLine(m1.GetHomeworkList());
    }

}