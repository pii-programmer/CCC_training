 using System;

class MyApp
{
    static void Main()
    {
        //for文
        // continue その条件だけ処理を中止して次のループへ
        // 結果は「0 1 2 3 4 6 7 8 9」
        for (var i = 0; i < 10; i++) {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        }

    }
}