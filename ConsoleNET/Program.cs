using System;

class User
{
    private string name = "me!";
    public string Name
    {
        get { return this.name; }
        set {
            if (value != "")
            {
                this.name = value;
            }
        }
            
    }

}

class MyApp
{
    static void Main()
    {
        User user = new User();              // User classのインスタンス userを生成。
        Console.WriteLine(user.Name);        // 結果は me! なぜならgetterだから。
        user.Name = "taguchi";
        Console.WriteLine(user.Name);        // 結果は taguchi なぜならsetterだから。
        user.Name = "";                      // 空ではない時だけ表示する処理にしてるので、空の時は
        Console.WriteLine(user.Name);        // 結果は taguchiのままになってくれる。
    }
}