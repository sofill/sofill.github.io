using System;

namespace Quiz05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제1
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            String userInput1 = Console.ReadLine();  //첫 번째 빈 칸
            int number1 = int.Parse(userInput1);
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            String userInput2 = Console.ReadLine();
            int number2 = int.Parse(userInput2); //두 번째 빈 칸
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);

            //문제 2
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput4 = Console.ReadLine();
            int number3 = int.Parse(userInput3);
            int number4 = int.Parse(userInput4); 

            Console.WriteLine(number3 - number4);

            //문제 3 다음 코드에서 문자열형 변수 userInput을 없애보세요?? 아.. string 안 쓰고 해 보라는 말
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput = Console.ReadLine();
            double number = double.Parse(userInput);
            Console.Write("입력한 숫자는  ");
            Console.WriteLine(number);

            Console.WriteLine("첫 번째 숫자를 입력해봥");
            double number5 = double.Parse(Console.ReadLine());
            Console.Write("입력한 숫자는?");
            Console.WriteLine(number5);
        }
    }
}
