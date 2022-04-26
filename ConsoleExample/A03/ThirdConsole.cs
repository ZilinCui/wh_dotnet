using System;
using System.Linq;

namespace ConsoleExample.A03{
    public class ThirdConsole{
        public ThirdConsole() {
            while (true) {
                Console.Write("请输入5个整数（空格分隔）：");
                string s = Console.ReadLine();
                if (s.Length == 0) return;
                string[] arr = s.Split(' ');
                if (arr.Length != 5) {
                    Console.WriteLine("错误：输入的不是5个数，请再次输入。");
                }
                else {
                    int[] nArray = new int[5];
                    bool flag = true;
                    for (int i = 0; i < arr.Length; ++i) {
                        if (int.TryParse(arr[i], out nArray[i]) == false) {
                            Console.WriteLine("错误：无法将\"{0}\"转换为整数，请再次输入。", arr[i]);
                            flag = false;
                        }
                    }

                    if (flag) {
                        Array.Sort(nArray);
                        Console.WriteLine("正序：{0}", string.Join(",", nArray));
                        Array.Reverse(nArray);
                        Console.WriteLine("逆序：{0}", string.Join(",", nArray));
                        Console.WriteLine("平均值：{0:f1}", nArray.Average());
                        Console.WriteLine("最大值：{0:f1}", nArray.Max());
                    }
                    else {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}