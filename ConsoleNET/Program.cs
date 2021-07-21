 using System;

class MyApp
{
    static void Main()
    {
        //信号機を条件分岐文で書いてみる。今回ユーザーからの入力は文字列なので、メソッドは不要、この書き方でOK。
        var signal = Console.ReadLine();
        //switchによる条件分岐文はこちら
        switch (signal)
        {
            case "red":
                Console.WriteLine("Stop!");
                break;
            case "blue":
            case "green": // or の時は、case を書き足す。
                Console.WriteLine("Go!");
                break;
            case "yellow":
                Console.WriteLine("Caution!");
                break;
            default:     // else の時は、default と書く。
                Console.WriteLine("wrong signal!");
                break;
        }
    }
} 