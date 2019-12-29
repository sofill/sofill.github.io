using System;

namespace Quiz07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열을 사용하여 다음 코드를 바꾸세요.


            double[] weights = new double[3];
            Console.Write("첫 번째 무게:   ");
            weights[0] = double.Parse(Console.ReadLine());
            Console.Write("두 번째 무게:   ");
            weights[1] = double.Parse(Console.ReadLine());
            Console.Write("세 번째 무게:   ");
            weights[2] = double.Parse(Console.ReadLine());

            Console.WriteLine(weights[0]);
            Console.WriteLine(weights[1]);
            Console.WriteLine(weights[2]);
        }
    }
}
