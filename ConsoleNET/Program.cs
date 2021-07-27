using System;

// class
// コンストラクタを使う
// コンストラクタはインスタンスを作る時に必ず呼ばれるメソッドである
// コンストラクタはクラスと同名のメソッドを定義してあげる

class User
{
    public string name;
    public User(string name)                     //これがコンストラクタ
    {
        // User classの外から値が渡ってきた（Tom）
        this.name = name;
    }
    public User()                   　　　　　　   //コンストラクタへクラス外から値が渡って来なかったら
    {
        this.name = "nobody";                    //"nobody"と表示してみる。このように同名のコンストラクタやメソッドを定義することをオーバーロードと言う。
    }
    public void SayHi()
    {
        Console.Write($"Hi! {this.name}");
    }
}

// User classの外である MyApp classから、User classへ値を渡すこともできる
class MyApp
{
    static void Main()
    {
        User tom = new User("Tom");  // User classのインスタンス tomを生成
        tom.SayHi();                 // Hi! Tom
        User user = new User();
        user.SayHi();                // Hi! nobody
    }
}