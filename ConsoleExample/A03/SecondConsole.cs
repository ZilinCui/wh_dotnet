using System;

namespace ConsoleExample.A03{
    public class SecondConsole{
        public SecondConsole() {
            while (true) {
                string str = Console.ReadLine();
                if (int.TryParse(str, out int n) == false) {
                    Console.WriteLine("你输入的不是整数或超出整数的表示范围，请重新输入。");
                    continue;
                }

                if (n < 0)
                    break;
                for (int j = 1; j <= n; j++) {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }
        }
    }
}