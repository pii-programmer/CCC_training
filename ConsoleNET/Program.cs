using System;

class User
{
    //private string name = "me!";
    //public string Name
    //{
    //    get { return this.name; }
    //    set { this.name = value; }
    //}

    // プロパティを一文で書く方法
    public string Name = { get; set;} = "me!";
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