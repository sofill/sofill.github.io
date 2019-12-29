using System;

namespace Quiz07_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "국어", "영어", "수학" };
            int[] scores = new int[3]; //요걸 기억 안나서 시간 걸렸음...ㅠㅠ

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[0]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[0]);

            Console.Write(subjects[1]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[1]);

            Console.Write(subjects[2]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[2]);
        }
    }
}
