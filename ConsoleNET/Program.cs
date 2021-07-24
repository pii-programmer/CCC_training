 using System;

class MyApp
{
    static void Main()
    {
        //配列の宣言
        //配列の中身を{}に書くときはint[]内に3は不要
        int[] scores = new int[] {10, 30, 20};

        //より省略した書き方
        int[] scores = { 10, 30, 20 };

        //型推論での書き方
        var scores = new [] { 10, 30, 20 };

    }
}