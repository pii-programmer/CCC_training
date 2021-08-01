using System;

// 抽象クラスとは、他のクラスを継承することを前提に作るクラスなので、抽象クラスのインスタンスを生成することは出来ない。
// 抽象クラスにするメリットは、各クラスの共通部分だけを切り出し、具象クラスに実装を任せることができること。

abstract class User                       // class Userを抽象クラスにする。その場合は abstractをつけてあげる。
{
    public abstract void sayHi();         // メソッドの中身は具象クラス（継承するクラス）で処理することにする。その場合は abstractをつけてあげる。
}

class Japanese: User      　　　　　　　　　// これが具象クラス。class Userを継承している class Japanese。
{
    public override void sayHi()         // 抽象クラスのsayHiメソッドの処理をここに書きたい。その場合は overrideをつけてあげる。
    {
        Console.WriteLine("こんにちは");   // ここに処理sayHiメソッドの処理を
    }
}

class American: User     　　　　　　　 　　// これが具象クラス。class Userを継承している class American。
{
    public override void sayHi()         // 抽象クラスのsayHiメソッドの処理をここに書きたい。その場合は overrideをつけてあげる。
    {
        Console.WriteLine("hi!");        // ここに処理sayHiメソッドの処理を
    }
}

class MyApp
{
    static void Main()
    {
        Japanese aki = new Japanese();   // Japaneseクラスのインスタンスを生成
        aki.sayHi();                     // 結果は こんにちは
        American tom = new American();   // Americanクラスのインスタンスを生成
        tom.sayHi();                     // 結果は hi!
    }
}