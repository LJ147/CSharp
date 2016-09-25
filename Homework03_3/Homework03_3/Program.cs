using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/// <summary>
/// 曹真
/// 2015302580272
/// </summary>
namespace Homework03_3
{
    class PrimeNumberUtil
    {

        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;   //可以整除为非质数 
                }
            }
            return true;
        }

        public static ArrayList Factorize(int x)
        {
            int k = 2; //将最小的质数赋值给k
            ArrayList primeFactors = new ArrayList();
            primeFactors.Add(1);

            //若输入的是最小质数2
            if (x == 2)
                primeFactors.Add(x);
            else
            {
                while (k <= x)
                {
                    if (x % k == 0)
                    {
                        primeFactors.Add(k);
                        x = x / k;              //除以最小质数后重新循环
                    }
                    else
                        k++;
                }
            }
                return primeFactors;
      }
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("请输入一个正整数：");
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number) && number > 0)
                {
                    PrimeNumberUtil prime = new PrimeNumberUtil();
                    if (IsPrime(number))
                    {
                        Console.WriteLine("该数字为质数，无质因数");
                    }
                    else
                    {
                        ArrayList nums = Factorize(number);
                        Console.Write("该数字的质因数：");
                        foreach (object obj in nums)
                        Console.Write("{0} ",obj.ToString());
                    }
                }
                else
                    Console.WriteLine("输入有误！");

            }
        }
    }
}
