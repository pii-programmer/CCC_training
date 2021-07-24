 using System;

class MyApp
{
    static void Main()
    {
        //配列の宣言
        //scoresという変数に代入される値は数値なので、int[]とする
        // int[3] とは、配列の中身が3つあるという意味。
        int[] scores = new int[3];
        //配列の中身それぞれに対して値を代入する
        scores[0] = 10;
        scores[1] = 30;
        scores[2] = 20;
    }
}