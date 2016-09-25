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
namespace Homework03_2
{
   
    class Student
    {
        int number;  //学号
        string name; //姓名


        //封装字段number name并使用属性
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //学生名称后缀
            string[] tails = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬" };
            Student[] initStudents = new Student[9];

            //创建学生对象，按照学号大小排序
            for (int i = 0; i < initStudents.Length; i++)
            {
                initStudents[i] = new Student();
                initStudents[i].Number = i + 1;
                initStudents[i].Name = "学生" + tails[i];
            }

            Console.WriteLine("输入需要查找的学号");
            int number = int.Parse(Console.ReadLine());
            Student findedStu = new Student();

            //调用二分查找函数，返回索引值
            int index = BinarySearch(initStudents, 0, initStudents.Length - 1, number);
            if (index != -1)
            { 
                findedStu = initStudents[index];
                Console.WriteLine("该学生信息：学号：{0}     姓名： {1}", findedStu.Number, findedStu.Name);
            } 
            else
                Console.WriteLine("查无此人！");

        }

        /// <summary>
        /// 二分查找 
        /// Student[] arr 学生数组 
        /// 
        /// </summary>


        public static int BinarySearch(Student[] arr, int low, int high, int number)
        {
            int mid = (low + high) / 2;
            if (low > high)
                return -1 ;
            else
            {
                if (arr[mid].Number == number)
                    return mid;
                else if (arr[mid].Number > number)
                    return BinarySearch(arr, low, mid - 1, number);
                else
                    return BinarySearch(arr, mid + 1, high, number);
            }
        }



    }
}
