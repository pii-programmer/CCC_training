 using System;

class MyApp
{
    static void Main()
    {
        //配列の宣言
        
        var scores = new [] { 10, 30, 20 };

        //for文：配列の 0~2 番を繰り返し表示する
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine(scores[i]);
        }
    }
}