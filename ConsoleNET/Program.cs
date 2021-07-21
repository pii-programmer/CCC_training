 using System;

class MyApp
{
    static void Main()
    {
        // each文＝ while文
        //ある条件が続く間、この処理を繰り返します。というのが while(ある条件){この処理}文
        var i = 100;

        while (i < 10)
        {
            Console.WriteLine($"ループ1:{i}");
            i++;
        }

        do
        {
            Console.WriteLine($"ループ2:{i}");
            i++;
        } while (i < 10);
        // do{この処理}while(ある条件);文は、まず{この処理}が実行されて、後から(ある条件)の判定がくる。だから、真偽に関わらず１回は必ず実行される。
        // ($"ループ1{i}") というのは、結果が見やすいように文字列にしているだけで、深い意味はない。
    }
} 