using System;

class MyApp
{
    static void Main()
    {
        var name = "taguchi";
        var score = 52.3;
        Console.WriteLine($"{name, 10} [{score, 10}]");             //10桁で表示する。右詰。
        Console.WriteLine($"{name, -10} [{score, -10}]");           //10桁で表示する。左詰。
        Console.WriteLine($"{name, -10} [{score, 10:0.00}]");       //10桁で表示する。浮動小数点。
        Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]");  //演算もできる。
    }
}