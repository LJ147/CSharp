using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork03_1
{
    class Program01
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            ArrayList numList = new ArrayList();
            int sum = 0;
            double average = 0;

            for (int i = 0; i < 30; i++)
            {
                int num = ran.Next(10, 101);
                numList.Add(num);
                sum += num;
                average = (double)sum / (i + 1);
            }
            Console.WriteLine("总和：{0}  平均数： {1}", sum, average);


        }
    }
}
