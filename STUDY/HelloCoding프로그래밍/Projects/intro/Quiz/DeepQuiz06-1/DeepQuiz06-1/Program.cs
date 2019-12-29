
using System;

namespace DeepQuiz06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //심화문제6-1 [코드6-3]을 else if를 사용하도록 수정하고 나머지 연산(%)도 추가하세요.
            //(힌트:6-4절에 나온 예제를 참고하세요.)

            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");

            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else if (inputOperator == "%")
            {
                Console.WriteLine(number1 % number2);
            }
        }
    }
}
