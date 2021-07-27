 using System;

class MyApp
{
    static void SayHi(string name, int age = 23)  //（型　引数）複数の引数でもOK。定義されていない引数の場合、初期値を与えることもできる。
    {
        Console.WriteLine($"hi! {name}({age})");
    }

    static void Main()
    {
        //別のクラスに引数として渡す時
        SayHi("Tom");                   //結果は hi! Tom(23)
        SayHi("Bob", 30);               //結果は hi! Bob(30)
        SayHi(age: 26, name: "Steve");  //結果は hi! Steve(26) 変数に代入して引数を渡すこともできる。
    }
}