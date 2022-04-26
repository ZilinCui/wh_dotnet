using System;
using System.Text;

namespace ConsoleExample.A03{
    public class FourthConsole{
        public FourthConsole() {
            for (int i = 1; i <= 1000; ++i) {
                StringBuilder sb = new StringBuilder();
                sb.Append("1");
                int s = 1;
                for (int j = 2; j <= Math.Sqrt(i); ++j)
                    if ((i / j) * j == i)
                        if ((i / j) == j) {
                            sb.Append("+").Append(j);
                            s += j;
                        }
                        else {
                            sb.Append("+").Append(j).Append("+").Append((i / j));
                            s += j + (i / j);
                        }

                if (s == i)
                    Console.WriteLine("{0}={1}", i, sb.ToString());
            }
        }
    }
}