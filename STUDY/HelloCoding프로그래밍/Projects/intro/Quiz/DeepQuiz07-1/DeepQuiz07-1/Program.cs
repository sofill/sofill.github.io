using System;

namespace DeepQuiz07_1
{
    class Program
    {
        static void Main(string[] args)
        { // 문제:학생 명부 프로그램에 몸무게도 넣고 싶습니다. [코드 7-4]를 수정해서 weights 배열을 추가하고 몸무게를 입력해 보세요. 
            Console.WriteLine("학생 수를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            double[] weights = new double[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber <= studentCount - 1)
            {
                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentNumber] = double.Parse(Console.ReadLine());

                Console.Write(studentNumber);
                Console.WriteLine(" 번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);
                Console.Write("몸무게: ");
                Console.WriteLine(weights[studentNumber]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요.");
            }
        }
    }
}
