using System;

class MyApp
{
    // static修飾子は
    // クラスのインスタンスを作らなくても、クラス外から、クラス内のフィールドやメソッドにアクセスできる。

    class User
    {
        private static int count = 0;   // これは countという staticフィールド
        public User()                   // これはコンストラクタ
        {
            User.count++;
        }
        public static void GetCount()   // これは GetCount というstaticメソッド
        {
            Console.WriteLine($"# of instances: {count}");
        }
    }

    static void Main()
    {
        User.GetCount();               // 結果は 0 のはず
        User user1 = new User();
        User user2 = new User();
        User user3 = new User();       // インスタンスを３つ作ったので
        User.GetCount();               // 結果は 3 のはず

    }
}