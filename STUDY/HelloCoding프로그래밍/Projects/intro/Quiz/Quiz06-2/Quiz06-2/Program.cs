using System;

namespace Quiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("먹은 사과의 개수를 입력하세요.");
            int appleEat = int.Parse(Console.ReadLine());
            if (appleEat > 3)
            {
                Console.WriteLine("너무 많이 먹었습니다.");
            }
            else if (appleEat < 3)
            {
                Console.WriteLine("너무 조금 먹었네요.");
            }
            else // else만 해도 되고, else if (appleEat = 3) 이라고 해도 되더라?
            {
                Console.WriteLine("적당이 먹었네요.^^");
            }
        }
    }
}
