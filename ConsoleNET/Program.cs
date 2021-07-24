 using System;

class MyApp
{
    static void Main()
    {
        //配列の宣言
        
        var scores = new [] { 10, 30, 20 };

        //変数の中身の上書きもできる
        scores[1] = 40;
        Console.WriteLine(scores[1]);
    }
}