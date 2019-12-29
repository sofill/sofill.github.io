using System;

namespace DeepQuiz06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //정수형 변수 userInput에 사용자의 입력을 받아서 userInput이 20보다 크고 3의 배수이면 
            //"20보다 큰 3의 배수입니다."를 출력하는 프로그램을 작성하세요.
            //(힌트:userInput % 3이 0이면 3의 배수입니다.)

            Console.WriteLine("숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());

            if ((number1 > 20) && (number1 % 3 == 0))
            {
                Console.WriteLine("오~ 잘했어요. 20보다 큰 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("틀렸지롱~");
            }

        }
    }
}
