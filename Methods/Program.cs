using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 =20;
            //int number2 = 100;
            //var result2 = Add3(ref number1,number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadKey();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int num1 = 20, int num2 = 30)
        {
            var result = num1 + num2;
            return result;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2,int num3)
        {
            return num1 * num2 * num3;
        }
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
