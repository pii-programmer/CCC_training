using System;

class MyApp
{
    //インデクサとは
    //クラスに対してインスタンスを生成する時、配列と同じようにインデックスを作成できること。

    class Team
    {
        private string[] members = new string[3];
        public string this[int i]
        {
            get { return this.members[i]; }
            set { this.members[i] = value; }
        }
    }

    static void Main()
    {
        Team giants = new Team();      // Team というクラスに giantsというインスタンスを生成
        giants[0] = "taguchi";
        giants[1] = "fkoji";
        giants[2] = "dotinstall";
        Console.WriteLine(giants[1]);  // 結果は fkoji
    }
}