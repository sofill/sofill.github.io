using System;

namespace DeepQuiz07_2
{
    class Program
    {
        static void Main(string[] args)
        { //문제 : 국어, 영어, 수학, 과학, 사회 점수를 입력받아서 총점과 평균을 구하는 프로그램을 작성하세요. (힌트: 점수에 배열을 사용하세요.)

            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[5];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[3]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(subjects[4]);
            Console.WriteLine("사회 점수를 입력하세요.");
            scores[4] = int.Parse(Console.ReadLine());


            if (scores[0] >= 0 && scores[0] <= 100 && scores[1] >= 0 && scores[1] <= 100 && scores[2] >= 0 && scores[2] <= 100 && scores[3] >= 0 && scores[3] <= 100 && scores[4] >= 0 && scores[4] <= 100)
            {
                Console.Write("총점은 ");
                Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
                Console.WriteLine("입니다.");
                Console.Write("평균은 ");
                Console.Write((scores[0] + scores[1] + scores[2] + scores[3] + scores[4])/5);
                Console.WriteLine("입니다.");
            }

            else
            {
                Console.WriteLine("점수를 잘못 입력하였습니다.");  //점수를 다 입력하고 나서야 이 문구가 나오는 것이 마음에 안듬.. 더 생각해보자. 
            }
        }
    }
}  