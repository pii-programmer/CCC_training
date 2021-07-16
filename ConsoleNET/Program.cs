using System;

class MyApp
{
    static void Main()
    {
        var name = "taguchi";
        var score = 52.3;
        Console.WriteLine(string.Format("{0} [{1}]", name, score)); //taguchi [52.3]
        Console.WriteLine($"{name} [{score}]"); //taguchi [52.3]
    }
}