using System;

class User
{
    private string name = "me!";
    // ↑セオリーとしては、安全性を考えてprivate, protectedのように必要な時だけアクセスできるアクセス修飾子にする。
    // ↓クラス外からアクセスしたい場合は、プロパティを持つことができる。これはC#の特徴。
    public string Name                      // これがフィールド
    {
        get { return this.name; }   // これが getter
        set { this.name = value; }  // これが setter
    }
}

class MyApp
{
    static void Main()
    {
        User user = new User();              // User classのインスタンス userを生成
        Console.WriteLine(user.Name);        // 結果は me! なぜならgetだから
        user.Name = "taguchi";
        Console.WriteLine(user.Name);        // 結果は taguchi なぜならsetだから
    }
}