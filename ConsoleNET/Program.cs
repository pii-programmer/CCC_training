using System;

class MyApp
{
    static void Main()
    {
        //変数：値の再代入が可能
        //定数：値の再代入が不可能
        //　定数の定義は const 定数の型 定数の名 =  "値";
        const string msg = "Hello World";
        Console.WriteLine(msg);
    }
}