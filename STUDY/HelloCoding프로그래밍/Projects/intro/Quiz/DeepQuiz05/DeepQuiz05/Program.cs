using System;

namespace DeepQuiz05
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1
            Console.WriteLine("숫자를 입력해 주십시오.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력해 주십시오.");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);

            Console.Write(number1);
            Console.Write(" - ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 - number2);

            Console.Write(number1);
            Console.Write(" * ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1*number2);

            Console.Write(number1);
            Console.Write(" / ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 / number2);

            //문제3
            //동전이 10개 들어있는 주머니가 있습니다. 
            Console.WriteLine("동전이 10개 들어있는 주머니가 있습니다.");
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int number5 = int.Parse(Console.ReadLine());
            Console.Write("주머니에 남아 있는 동전의 개수는 ");
            Console.Write(10 + number3 - number4 - number5);
            Console.WriteLine("개입니다.");

        }
    }
}
