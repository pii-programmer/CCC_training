 using System;

class MyApp
{
    static void Main()
    {
        //ユーザーから入力を受け取る＝ Console.ReadLine
        //入力された値は整数型で受け取りたいので＝ int.Parse()
        var score = int.Parse(Console.ReadLine());
        if (score > 80)
        {
            Console.WriteLine("Great!");
        } else if (score > 60) {
            Console.WriteLine("Good!");
        } else {
            Console.WriteLine("so so...");
        }
    }
}