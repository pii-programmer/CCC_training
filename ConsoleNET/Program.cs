 using System;

class MyApp
{
    static void SayHi(string name)  //（型　引数）
    {
        Console.WriteLine($"hi! {name}");
    }

    static void Main()
    {
        //別のクラスに引数として渡す時
        SayHi("Tom");
    }
}