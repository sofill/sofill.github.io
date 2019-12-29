using System;

namespace Quiz04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10 + 5);
            Console.WriteLine(20 - 10);
            Console.WriteLine(4 * 7);
            Console.WriteLine(20 / 7);
            Console.WriteLine(20 % 7);

            Console.WriteLine("안녕" + "하세요");

            int number1 = 20;
            int number2 = 5;
            int number3 = 3;
            int number4 = 13;
            int number5;

            number1 = number1 + number2;
            number2 = number3 + number4;
            number4 = number1 - number4;
            number3 = number2 / number4;
            number5 = number2 % number4;

            Console.WriteLine(number1); //25
            Console.WriteLine(number2); //16
            Console.WriteLine(number3); // 1
            Console.WriteLine(number4); //12 
            Console.WriteLine(number5); // 4
        }
    }   
}
