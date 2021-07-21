 using System;

class MyApp
{
    static void Main()
    {
        // each文＝ while文
        //ある条件が続く間、この処理を繰り返します。というのが while(ある条件){この処理}文
        var i = 0;

        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
} 