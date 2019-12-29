using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcodeNumbers1 = 6;
            int passcodeNumbers2 = 2;
            int passcodeNumbers3 = 1;
            int passcodeNumbers4 = 9;
            int passcodeNumbers5 = 4;
            int passcodeNumbers6 = 7;

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 넣어주세요.");
            int userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 넣어주세요.");
            int userInput4 = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 넣어주세요.");
            int userInput5 = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 넣어주세요.");
            int userInput6 = int.Parse(Console.ReadLine());

            if (userInput1 == passcodeNumbers1 && userInput2 == passcodeNumbers2 && userInput3 == passcodeNumbers3 && userInput4 == passcodeNumbers4 && userInput5 == passcodeNumbers5 && userInput6 == passcodeNumbers6)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다.");
            }
        }
    }
}
