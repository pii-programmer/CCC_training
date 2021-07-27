using System;

// class
// コンストラクタを使う
// コンストラクタはインスタンスを作る時に必ず呼ばれるメソッドである
// コンストラクタはクラスと同名のメソッドを定義してあげる

class User
{
    public string name;
    public User()                     //これがコンストラクタ
    {
        // ここにクラスと同名のメソッドを定義してあげる
        this.name = "ME";
    }
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
        user.SayHi();                 // Hi! ME
    }
}