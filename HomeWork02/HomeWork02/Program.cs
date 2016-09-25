using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/// <summary>
/// 学生信息 ： 曹真 2015302580272 
/// 第二次作业
/// </summary>
/// 
namespace HomeWork02
{

    class Program
    {
        static void Main(string[] args)
        {
           program8_19();
           // program5_41_2();
        }

        /// 5.19题 

        static void program5_19()
        {
            double[] prices = { 239.99, 129.75, 99.95, 350.89 };
            double sum = 0;
            for (int i = 0;i < 4;i++)
            {
                Console.WriteLine("请输入第{0}种商品的销量：", i+1);
                double num = double.Parse(Console.ReadLine());
                sum = sum + num * prices[i];
            }
            Console.WriteLine("总收入：{0}",(sum * 0.09+200));
        }

        /// 5.20题 

        static void program20()
        {
            ArrayList names = new ArrayList();
            double[] workHours = new double[3];
            double[] salaries = new double[3];

            for (int i = 0; i <3 ; i++)
            {
                Console.WriteLine("请输入第{0}位工人的姓名：", i + 1);
                names.Add(Console.ReadLine());
                Console.WriteLine("请输入第{0}位工人的工作时长：", i + 1);
               workHours[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第{0}位工人的每小时工资：", i + 1);
                salaries[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("第{0}位工人：{1}的工资：{2}",i+1,names[i], workHours[i]<40 ?  (workHours[i] *salaries[i]) : ( 40* salaries[i]+1.5*salaries[i]* (workHours[i]-40)));
            }
        }

        /// 5.21题 
        /// 查找最大数

        static void program5_21()
        {
            int count = 0;
            int number = 0;
            int largest = 0;
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入数字:");
                number = int.Parse(Console.ReadLine());
                nums[i] = number;
                Array.Sort(nums);
                largest = nums[nums.Length - 1];
                count++;
            }
            Console.WriteLine("最大值："+largest);

        }



        /// <summary>
        /// 5.30 回文数
        /// </summary>
        /// 

        static void program5_30()
        {
            bool IsRight = true;                 //是否为回文数
            int num = int.Parse(Console.ReadLine());
            int[] numList = new int[5];

            if (num < 100000 &&num > 9999)
            {
                //循环取值、赋值
                int n = num;
                for (int i = 0; i < numList.Length; i++, n = n / 10)
                {             
                    numList[i] = n % 10;
                }
                //循环检测，判断是否对称位相等
                for (int i = 0; i < 3; i++)
                {
                    if (numList[i] != numList[4 - i])
                    {
                        Console.WriteLine("非回文");
                        IsRight = false;
                        return;
                    }
                }
                if (IsRight)
                {
                    Console.WriteLine("回文");
                }
            }
            else
            {
                Console.WriteLine("请输入五位数字");
            }
        }

        ///5.31题 
        ///二进制转十进制
        /// 

        static void program5_31()
        {
            Console.WriteLine("输入二进制数字：");
            int num = int.Parse(Console.ReadLine());
            ArrayList numList = new ArrayList();
            for (int n = num; n > 0; n = n / 10)
            {
                numList.Add(n % 10);
            }
            //反转数组 回到正常顺序 
            numList.Reverse();            
            //foreach (Object obj in numList)
            //    Console.Write("   {0}", obj);
            int result = 0;
           for(int i = 0; i<numList.Count;i++)
            {
                result = result +int.Parse(numList[i].ToString())*int.Parse(Math.Pow(2, i).ToString());
            }
            Console.WriteLine("十进制："+result);
        }



        ///5.35题 
        ///检测是否构成三角形
        ///

        static bool program5_35()
        {
            Console.WriteLine("输入边长：");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 + num2 > num3  && num2 + num3 > num1 && num1 + num3 > num2)
            {
                Console.WriteLine("能构成三角形");
                return true;
            }
            else
            {
                Console.WriteLine("不能构成三角形");
                return false;
            }

        }
        ///5.36题 
        ///检测是否组成直角三角形
        ///

        static void program5_36()
        {
            Console.WriteLine("输入边长：");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2)
            {
                if (Math.Pow(num1, 2)+ Math.Pow(num2, 2)== Math.Pow(num3, 2) ||
                    Math.Pow(num1, 2) + Math.Pow(num3, 2) == Math.Pow(num2, 2)||
                    Math.Pow(num3, 2) + Math.Pow(num2, 2) == Math.Pow(num1, 2) )
                {
                    Console.WriteLine("可以构成直角三角形：");
                }
                else
                {
                    Console.WriteLine("不能构成直角三角形：");
                }
            }
        }

        ///5.37题 
        ///求解阶乘
        ///

        static void program5_37()
        {
            Console.WriteLine("输入正整数：");
            int num = int.Parse(Console.ReadLine());
            double result = 1;
            if (num > 0)
            {
                for (int i = 1; i < num + 1; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("阶乘是：" + result);
            }
            else
            {
                Console.WriteLine("输入有误，请输入正数字：");

            }

        }
        ///5.38题 
        ///估算e值
        ///

        static void program5_38()
        {
            double result = 1;
            double temp = 1;
            double sum = 1;
            //double max = 10000;

            Console.WriteLine("输入最大n值：");
            double max = double.Parse(Console.ReadLine());


            for (double i = 1; i < max; i++)
                {
                    temp = temp * i;
                    result = 1 / temp;
                    sum = sum + result;
                }
             Console.WriteLine("估算结果是：" + sum);
             Console.WriteLine("计算机预定义常量e是：" + Math.E);

        }

        ///5.41题 
        ///加密程序
        ///

        static void program5_41()
        {

            Console.WriteLine("输入原文：");
            string content = Console.ReadLine();

           if(content.Length == 4)
            {
                //第一次  运算加密
                ArrayList tempText = new ArrayList();
                for (int i = 0; i < 4; i++)
                {
                    tempText.Add(content[i]);
                    //Console.WriteLine(content[i]);
                }

                //第二次 变换位置
                ArrayList cipherText = new ArrayList();
                cipherText.Add(tempText[2]);
                cipherText.Add(tempText[3]);
                cipherText.Add(tempText[0]);
                cipherText.Add(tempText[1]);

                //赋值给cipherContent
                int cipherContent = 0;
                for (int i = 0; i < 4; i++)
                {
                    cipherContent = cipherContent + int.Parse(cipherText[i].ToString()) * int.Parse(Math.Pow(10, 3 - i).ToString());
                }
                //保证四位输出
                Console.WriteLine("密文：{0:D4}", cipherContent);
            }
            else
            {
                Console.WriteLine("输入有误");
            }


        }
        /// <summary>
        ///   解密程序
        /// </summary>


        static void program5_41_2()
        {

            Console.WriteLine("输入密文：");
            string content = Console.ReadLine();

            //第一次  
            ArrayList tempText = new ArrayList();         
            for (int i = 0; i < 4; i++)
            {
                tempText.Add(content[i]);
            }

            //第二次 变换位置
            ArrayList cipherText = new ArrayList();
            cipherText.Add(tempText[2]);
            cipherText.Add(tempText[3]);
            cipherText.Add(tempText[0]);
            cipherText.Add(tempText[1]);

            //赋值给cipherContent
            int cipherContent = 0;
            for (int i = 0; i < 4; i++)
            {
                cipherContent = cipherContent + int.Parse(cipherText[i].ToString()) * int.Parse(Math.Pow(10, 3 - i).ToString());
            }
            //第三次  
            ArrayList finalText = new ArrayList();
            for (int n = cipherContent; n > 0; n = n / 10)
            {
                finalText.Add(n % 10);
            }
            Console.WriteLine("原文：{0:D4}", cipherContent);

        }

        ///8.8题 

        static void program8_8()
        {
            //打印索引号为8的元素
            char[] f =  new char[10];
            f[7] = 'H';
            Console.WriteLine("索引号为8："+f[7]);

            //初始化全部五个元素为8
            int[] g = new int[8];
            for(int i =0;i<8;i++)
            {
                g[i] = 8;
            }

            //数组求和
            double[] c = new double[100];
            double sum = 0;
            for (int i = 0; i < 100; i++)
            {
                c[i] = 1;
                sum += c[i];
            }
            Console.WriteLine(sum);

            //复制数组
            int[] a = new int[11];
            int[] b = new int[34];
            for (int i = 0; i < 11; i++)
            {
                a[i] = 1;      
            }
            for (int i = 0; i < 11; i++)
            {
                b[i] = a[i];
            }

            //数组Sort求解 最大最小值
            double[] nums = new double[99];
           
            for (int i = 0; i < 99; i++)
            {
                nums[i] = i + 3;
            }
            Array.Sort(nums);
            double max = nums[nums.Length - 1];
            double min = nums[0];

        }
     

        ///8.9题 

        static void program8_9()
        {
            int[,] nums = { { 1,2,3}, {4,5,6 } };
            /* 输出数组中第二列的值 */
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}   ",nums[1,i]);
            }
            /* 输出数组中每个元素的值 */
            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0}   ", nums[i, 2]);
            }
            nums[0, 1] = 0; //
            //
            /*
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nums[i, j] = 3; 
                }
            }
            */
            //
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("输入数字：");
                    int num = int.Parse(Console.ReadLine());
                    nums[i, j] = num;
                }
            }
            int minNum  = nums[0,0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (nums[i, j] < minNum)
                    {
                        minNum = nums[i, j];
                    }
                }
            }
            Console.WriteLine("minValue："+minNum);

            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                sum += nums[i, 2];
                Console.Write("{0}   ", sum);

            }
        }

        ///8.11题 

        static void program8_11()
        {
            int[] counts = new int[3];
            for(int i = 0; i < 3; i++)
            {
                counts[i] = 0;
            }

            int[] bonus =  { 1,2,3,4};

            for (int i = 0; i < 3; i++)
            {
                bonus[i] += 1 ;
            }

            int[] bestScore = { 1, 2, 3, 4 ,5};

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("第{0}数字:{1}"  ,i+1, bestScore[i]);
            }
        }

        ///8.16题 

        static void program8_16()
        {
            int maxLength = 0;
            Console.WriteLine("请输入数字总个数");
            maxLength = int.Parse(Console.ReadLine());
            ArrayList numList = new ArrayList();
            for (int i = 0; i < maxLength; i++)
            {
                Console.WriteLine("请输入数字，按回车录入");
                numList.Add(int.Parse(Console.ReadLine()));
            }
            int sum = 0;
            for (int i = 0; i < maxLength; i++)
            {
                sum += int.Parse(numList[i].ToString());
            }
            Console.WriteLine("求和结果："+sum);


        }

        ///8.17题 

        static void program8_17()
        {
            Random ran1 = new Random();

            int[] numList1 = new int[36000];
            int[] numList2 = new int[36000];
            int[] sumList = new int[36000];
            int countNum = 0;

            double precision = 0.0;//误差精确度
            Console.WriteLine("输入误差精确度：");
            precision = double.Parse(Console.ReadLine());

            //
            for (int i = 0; i < 36000; i++)
            {
                //此处必须使用相同的种子 new两个种子会产生相同的随机数
                int num1 = ran1.Next(1, 7);
                int num2 = ran1.Next(1, 7);
                //记录结果中求和为7的次数
                if ((num1+num2) == 7)
                {
                    countNum++;
                }
            }

            //比较绝对值相差数值
           if(System.Math.Abs(countNum / 36000.0 - 1.0 / 6)  < precision)
            {
                Console.WriteLine("误差不超过{0}",precision);
                Console.WriteLine("7的出现次数：{0}", countNum);
            }
            else
            {
                Console.WriteLine("误差超过{0}",precision);
                Console.WriteLine("7的出现次数：{0}", countNum);
            }



        }

        ///8.19题  航空订座系统

        static void program8_19()
        {
            bool[] seatLists = new bool[10]; //座位数组
            int economyCount = -1;  //经济舱计数 0 1 2 3 4 
            int FirstClassCount = -1; //头等舱计数 0 1 2 3 4 
            int choice = 0;  

            /* while 循环输入 */
            while (true) 
            {
                Console.WriteLine("**********            Hint               *************");
                Console.WriteLine("*        Please type 1 for  First Class              *");
                Console.WriteLine("*        Please type 2 for  Economy                  *");
                Console.WriteLine("**********            Hint               *************");

                choice = int.Parse(Console.ReadLine());

                /* 分经济舱、头等舱进行选择 */
                switch (choice)
                {
                    case 1:
                        //经济舱人数未满
                        if (FirstClassCount < 4)
                        {
                            FirstClassCount++;
                            seatLists[FirstClassCount] = true;
                            Console.WriteLine("Succeed! Your Seat number is {0}", FirstClassCount+1);
                        }
                        //经济舱人数已满
                        else
                        {
                            if (economyCount < 4)  //经济舱人数已满 && 头等舱舱人数未满
                            {
                                Console.WriteLine("First Class Room is full,do you want to change to economy? 1:Yes, 2: No");
                                int choiceA;
                                choiceA = int.Parse(Console.ReadLine());
                                switch (choiceA)
                                {
                                    case 1:
                                        economyCount++;
                                        seatLists[economyCount + 5] = true;
                                        Console.WriteLine("Succeed! Your Seat number is {0}", economyCount + 6);
                                        break;
                                    case 2:
                                        Console.WriteLine("Next Flight leaves in 3 hours");
                                        break;
                                    default:
                                        Console.WriteLine("Error Input, Please type again!");  //输入错误数字，提示重新输入
                                        break;
                                }
                            }
                            else  //经济舱人数已满 && 头等舱舱人数也已满
                            {
                                Console.WriteLine("All rooms are full !");
                            }
                        }
                        break;
                    case 2:
                        if(economyCount < 4)  //头等舱人数未满
                        {
                            seatLists[economyCount + 5] = true;
                            economyCount++;
                            Console.WriteLine("Succeed! Your Seat number is {0}", economyCount + 6);
                        }
                        else  
                        {
                            if (FirstClassCount < 4) //头等舱人数已满 && 经济舱人数未满
                            {
                                Console.WriteLine("Economy Room is full,do you want to change to First Class? 1:Yes, 2: No");
                                int choiceB;
                                choiceB = int.Parse(Console.ReadLine());
                                switch (choiceB)
                                {
                                    case 1:
                                        FirstClassCount++;
                                        seatLists[FirstClassCount] = true;
                                        Console.WriteLine("Succeed! Your Seat number is {0}", FirstClassCount + 1);
                                        break;
                                    case 2:
                                        Console.WriteLine("Next Flight leaves in 3 hours");
                                        break;
                                    default:
                                        Console.WriteLine("Error Input, Please type again!");  //输入错误数字，提示重新输入
                                        break;
                                }
                            }
                            else  //头等舱人数已满 && 经济舱人数已满
                            {
                                Console.WriteLine("All rooms are full !");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Error Input, Please type again!"); //输入错误数字，提示重新输入
                        break;
                }


                
                
                //分界线
            }
        }



    }
    }


/// <summary>
/// 学生信息 ： 曹真 2015302580272 
/// 第二次作业
/// </summary>