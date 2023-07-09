using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //숫자를 입력받아 그 숫자가 짝수인지 홀수인지 판단하는 프로그램
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("입력하신 숫자는 짝수입니다.");
            }
            else
            {
                Console.WriteLine("입력하신 숫자는 홀수입니다.");
            }

        }
        

    }
}
