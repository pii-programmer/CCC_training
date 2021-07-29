using System;

// classの継承
// User classを継承した AdminUser classを作る

class User                                       //これが親クラス
{
    private string name;
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
        Console.WriteLine(tom.name);             // 結果は エラー    アクセス修飾子がprivateだから。AdminUserとMyApp両方からアクセスできない。
        tom.SayHi();                             // 結果は Hi! Tom
        AdminUser bob = new AdminUser("Bob");    // AdminUser classのインスタンス bobを生成
        bob.SayHi();                             // 結果は [admin] Hi! Bob
        bob.SayHello();                          // 結果は Hello! Bob
    }
}