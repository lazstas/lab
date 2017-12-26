using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate float PowOrDiv(float x1, float x2);
        static float Pow(float i, float j)
        {
            return i * j;
        }
        static float Div(float i, float j)
        {
            return i / j;
        }
        static void Res(string str, float i, float j, PowOrDiv PowOrDivParam)
        {
            float N = PowOrDivParam(i, j);
            Console.WriteLine(str + N.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("x = 666");
            Console.WriteLine("y = 228");
            float i = 666, j = 228;
            string str1 = "Умножение: ";
            Res(str1, i, j, (x, y) => { return x * y; });
            string str2 = "Деление: ";
            Res(str2, i, j, (x, y) => { return x / y; });
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Использование обощенного делегата Action<>:");
            Action<float, float> a1 = (x, y) => {
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            };
            Action<float, float> a2 = (x, y) => {
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            };
            Action<float, float> group = a1 + a2;
            group(i, j);
            Console.ReadKey();
        }
    }
}