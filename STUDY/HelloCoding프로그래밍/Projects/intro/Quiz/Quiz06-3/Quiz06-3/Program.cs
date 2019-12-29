using System;

namespace Quiz06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("등수를 입력하세요.");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());

            if (rank < 10 || score > 90)
            {
                Console.WriteLine("A입니다.");
            }
        }
    }
}
