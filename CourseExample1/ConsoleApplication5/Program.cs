/*
 *第一次C#课程作业示例代码
 *
 *作者：贾向阳
 *
 * */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISS.CSharp.Example
{
    /// <summary>
    ///  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //program24();
            //program26();
            //program27();
            program28();
        }

        /// <summary>
        /// 24题示例
        /// </summary>
        static void program24()
        {
            int num = int.Parse(Console.ReadLine());
            string str = (num % 2 == 0) ? "偶数" : "奇数";
            Console.WriteLine("{0}是" + str + "!", num);
        }


        /// <summary>
        /// 26题示例
        /// </summary>
        static void program26()
        {
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("diameter={0}", radius * 2);
            Console.WriteLine("circumference={0:f3}", radius * 2 * Math.PI);
            Console.WriteLine("area={0:f3}", radius * radius * Math.PI);
        }

        /// <summary>
        /// 27题示例
        /// </summary>
        static void program27()
        {
            char[] chars = { 'A', 'B', 'C', 'a', 'b', 'c', '0', '1', '2', '$', '*', '+', '/', ' ' };
            foreach (char c in chars)
            {
                Console.WriteLine("{0}={1}", c, (int)c);
            }
        }

        /// <summary>
        /// 28题示例
        /// 采用循环除10的方法摘取每一位数字
        /// </summary>
        static void program28()
        {
            int num = int.Parse(Console.ReadLine());
            ArrayList numList = new ArrayList(); //分解后的数字
            for (int n = num; n > 0; n = n / 10)
            {
                numList.Add(n % 10);
            }
            Console.WriteLine("{0}分解后数字为:", num);
            for (int i = numList.Count - 1; i >= 0; i--)
            {
                Console.Write("{0}   ", numList[i]);
            }
        }
    }


}
