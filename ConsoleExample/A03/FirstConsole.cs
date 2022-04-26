using System;

namespace ConsoleExample.A03{
    public class FirstConsole{
        public FirstConsole() {
            string str = "";
            while (true) {
                Console.Write("请输入一个长度大于3的字符串：");
                str = Console.ReadLine();
                if (str.Length >= 4) {
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine("字符串长度不符合要求，请重新输入！");
            }

            Console.WriteLine("（1）字符串的长度为：{0}", str.Length);

            int i = str.IndexOf('a');
            if (i == -1) {
                Console.WriteLine("（2）字符串中不包含字母a。");
            }
            else {
                Console.WriteLine("（2）第一个出现字母a的位置是：{0}", i);
            }

            string str1 = str.Insert(3, "hello");
            Console.WriteLine("（3）插入hello后的结果为：{0}", str1);

            string str2 = str1.Replace("hello", "me");
            Console.WriteLine("（4）将hello替换为me后的结果为：{0}", str2);

            string[] arr = str2.Split('m');
            Console.Write("（5）以m为分隔符分离后的字符串有{0}个：", arr.Length);
            for (int j = 0; j < arr.Length; j++) {
                Console.Write(arr[j] + " ");
            }

            Console.WriteLine("\n请按任意键继续...");

            Console.Read();
        }
    }
}