using System;

namespace ConsoleExample.A04{
    public class FirstConsole{
        public FirstConsole() {
            var a = new A();
            var b = new A("This is a string");
            A[] aArr = new A[5];
        }
    }

    class A{
        //（1）
        public A() {
            Console.WriteLine(this);
        }

        //（2）
        public A(string str) {
            Console.WriteLine(str);
        }
    }
}