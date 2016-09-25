using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Example8_17();
            Example8_19();
        }
        

        public static void Example8_17()
        {
            const int N = 3600;
            Random random = new Random();
            int[] points= new int[11];
            for (int i = 0; i < N; i++)
            {
                points[random.Next(1, 7) + random.Next(1, 7) - 2]++;
            }
            for (int i = 0; i < points.Length; i++)
            {
                System.Console.WriteLine("{0}点概率：{1:f4}", i + 2, (float)points[i] / N);
            }
        }

     

        private static void Example8_19()
        {
            bool[] seats = new bool[10];//defaul values are all False
            int nextFirstClassSeat = 0;
            int nextEconomySeat = seats.Length / 2;

            while (true)
            {
                Console.Write("Please type 1 for First Class, please type 2 for Economy:");
                int seatType = int.Parse(Console.ReadLine());
                if (seatType != 1 && seatType != 2)
                {
                    Console.WriteLine("Invalid input！");
                    continue;
                }

                //check avaliability
                if (nextFirstClassSeat > 4 && nextEconomySeat > 9)
                {
                    Console.WriteLine("No seat is avaliable！");
                    return;
                }

                //change seat type?
                string change = null;
                if (seatType == 1 && nextFirstClassSeat > 4 && nextEconomySeat <= 9)
                {
                    Console.WriteLine("No first class seats is avaliable，would you like to change to economy seats？(Y/N)");
                    change = Console.ReadLine();
                }
                else if (seatType == 2 && nextEconomySeat > 9 && nextFirstClassSeat <= 4)
                {
                    Console.WriteLine("No economy seats is avaliable，would you like to change to first class seats？(Y/N)");
                    change = Console.ReadLine();
                }

                if ("Y".Equals(change) || "y".Equals(change))
                {
                    seatType = (seatType == 1) ? 2 : 1;
                }
                else if ("N".Equals(change) || "n".Equals(change))
                {
                    Console.WriteLine("Next flight leaves in 3 hours!");
                    continue;
                }
                else if (change != null)
                {
                    Console.WriteLine("Invalid input！");
                    continue;
                }

                // arrange seat
                if (seatType == 1)
                {
                    Console.WriteLine("arrange to seat {0}:", nextFirstClassSeat);
                    seats[nextFirstClassSeat++] = true;
                }
                else
                {
                    Console.WriteLine("arrange to seat {0}:" , nextEconomySeat);
                    seats[nextEconomySeat++] = true;
                }
            }
        }

    }
}
