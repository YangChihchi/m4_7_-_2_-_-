using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("開始");
        // fix #1    印出 九九乘法表
        //  煩請用 while 做出來
        int i, j;
        for (i = 1; i < 5; i++)
        {
            for (j = 1;j<i; j++)
            {
                Console.Write("*");
                Console.WriteLine("");
            }
        }


        //Console.WriteLine("1x1= 1 1x2= 2 1x3= 3 1x4= 4 1x5= 5 1x6= 6 1x7= 7 1x8= 8 1x9= 9 ");
        //Console.WriteLine("2x1= 2 2x2= 4 2x3= 6 2x4= 8 2x5=10 2x6=12 2x7=14 2x8=16 2x9=18 ");

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

