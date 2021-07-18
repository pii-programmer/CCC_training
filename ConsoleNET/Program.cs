 using System;

class MyApp
{
    static void Main()
    {
        //まず関数 score を定義する。
        var score = int.Parse(Console.ReadLine());
        //if文の省略した書き方
        Console.WriteLine((score > 80) ? "Great" : "so so...");
        //Console.WriteLine((条件式)? "条件式がTrueならA" ："FalseならBと表示する");
    }
}