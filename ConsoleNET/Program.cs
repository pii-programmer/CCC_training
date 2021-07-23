 using System;

class MyApp
{
    static void Main()
    {
        //for文
        // break
        // 結果は「0 1 2 3 4」
        for (var i = 0; i < 10; i++) {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);
        }

    }
}