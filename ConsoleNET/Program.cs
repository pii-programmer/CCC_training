using System;

// classの作り方
// 変数（フィールド）とメソッドを定義する
// this.変数名 でメソッドからフィールドにアクセスすることもできる

class User
{
    public string name = "me";
    public void SayHi()
    {
        Console.Write($"Hi! {this.name}");
    }
}

// 上記で定義した User classを MyApp classで使う
class MyApp
{
    static void Main()
    {
        User user = new User();       // User classのインスタンス userを生成
        Console.WriteLine(user.name); // 生成したインスタンス userの中の nameの値を取ってくる。結果は me
        user.SayHi();                 // Hi! me
        user.name = "taguchi";        // userインスタンスの nameを"taguchi"に上書きする
        user.SayHi();                 // Hi! taguchi
    }
}