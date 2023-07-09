using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MethodStudy
{
    class Program
    {
        //함수를 선언하면서 매개변수의 기본값을 지정하는 프로그램 
        //추가 : 두 수를 입력받아 비교하는 프로그램
        static void ComparisonNum(double num1 = 1.0, double num2 = 2.0)
        {
            if (num1 > num2)
            {
                Console.WriteLine("첫 번째 숫자가 더 큽니다.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("두 번째 숫자가 더 큽니다.");
            }
            else
            {
                Console.WriteLine("두 수는 같습니다.");
            }
        }
        static void Main(string[] args)
        {
            ComparisonNum();
            ComparisonNum(5);
            ComparisonNum(10.5, 10.5);

            Console.Write("첫 번째 숫자를 입력하세요 : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요 : ");
            double y = Convert.ToDouble(Console.ReadLine());

            ComparisonNum(num2: x, num1: y);
        }


    }
}
