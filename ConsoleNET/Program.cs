using System;

// classの継承
// User classを継承した AdminUser classを作る

class User                                       //これが親クラス
{
    public string name;
    public User(string name)                     //これが親クラスのコンストラクタ
    {
        // User classの外から値が渡ってきた（Tom）
        this.name = name;
    }
    
    public virtual void SayHi()                  //メソッド SayHi()を子クラスが上書きしているので virtualとする
    {
        Console.Write($"Hi! {name}");            // thisを省略もできる
    }
}

class AdminUser: User                            //子クラスにコンストラクタは継承されない。その他は全て継承される。
{
    public AdminUser(string name) : base(name) { // base()は親クラスのコンストラクタのこと
    }
    public void SayHello()                       //子クラス内にも新しいメソッドを定義できる 
    {
        Console.Write($"Hello! {name}");
    }
    public override void SayHi()
    {
        Console.Write($"[admin] Hi! {name}");    //親クラスのメソッドを上書きする時 overrideとする。( [admin]は区別のために書いただけ）
    }
}

class MyApp
{
    static void Main()
    {
        User tom = new User("Tom");              // User classのインスタンス tomを生成
        tom.SayHi();                             // Hi! Tom
        AdminUser bob = new AdminUser("Bob");    // AdminUser classのインスタンス bobを生成
        bob.SayHi();                             // Hi! Bob
        bob.SayHello();                          // Hello! Bob
    }
}