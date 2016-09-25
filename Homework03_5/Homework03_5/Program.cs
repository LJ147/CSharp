using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Homework03_5
{
    //学生类 包括姓名和成绩
    class Student
    {
        // 封装
        private string name;
        private int score;
        //C#属性访问
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
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

    }
    //成绩管理类
    class ScoreService
    {
        //存储学生信息
        //ArrayList studenstList = new ArrayList();
        Student stu = new Student();
        List<Student> studenstList = new List<Student>();

        internal List<Student> StudenstList
        {
            get
            {
                return studenstList;
            }

            set
            {
                studenstList = value;
            }
        }


        //添加记录
        public void AddPerson(Student stu)
        {
            StudenstList.Add(stu);
        }
        //查询成绩
        public int InquiryScore(List<Student> array, string name)
        {
            for (int index = 0; index < array.Count; index++)
            {
                if (array[index].Name.Equals(name))
                    return index;
            }
            return -1;
        }
        //删除成绩
        public bool DeleteRecord(List<Student> array, string name)
        {
            for (int index = 0; index < array.Count; index++)
            {
                if (array[index].Name.Equals(name))
                {
                    array.Remove(array[index]);
                    return true;
                }
            }
            return false;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //实例化成绩管理类
            ScoreService scoreService = new ScoreService();
            bool controller = true;
            while (controller)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("*输入1手动录入学生成绩:***");
                Console.WriteLine("*输入2查询学生成绩:*******");
                Console.WriteLine("*输入3删除学生成绩:*******");
                Console.WriteLine("*输入4修改学生成绩:*******");
                Console.WriteLine("*输入5退出系统    ********");
                Console.WriteLine("**************************");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {

                        case 1:
                            while (Console.ReadLine() != "inputDone")
                            {
                                Student student = new Student();

                                Console.WriteLine("输入姓名 ：");
                                student.Name = Console.ReadLine();
                                Console.WriteLine("输入成绩：");
                                int score;
                                if (int.TryParse(Console.ReadLine(), out score))
                                {
                                    student.Score = score;
                                    scoreService.AddPerson(student);
                                    Console.WriteLine("输入 inputDone 结束录入，Enter继续录入：");
                                }
                                else
                                    Console.WriteLine("成绩输入有误");
                            }
                            break;
                        case 2:
                            Console.WriteLine("输入查询姓名 ：");
                            string name = Console.ReadLine();
                            int index = scoreService.InquiryScore(scoreService.StudenstList, name);
                            if (index != -1)
                            {
                                Student tempStu = scoreService.StudenstList[index];
                                Console.WriteLine("学生姓名：{0}  成绩：{1}", tempStu.Name, tempStu.Score);
                            }
                            else
                                Console.WriteLine("查无此人！");
                            break;
                        case 3:
                            Console.WriteLine("输入要删除的姓名 ：");
                            string name03 = Console.ReadLine();
                            int index03 = scoreService.InquiryScore(scoreService.StudenstList, name03);
                            if (index03 != -1)
                            {
                                scoreService.StudenstList.Remove(scoreService.StudenstList[index03]);
                                Console.WriteLine("删除成功！：");
                            }
                            else
                                Console.WriteLine("查无此人！");
                            break;
                        case 4:
                            Console.WriteLine("输入要修改成绩的姓名 ：");
                            string name04 = Console.ReadLine();
                            int index04 = scoreService.InquiryScore(scoreService.StudenstList, name04);

                            if (index04 != -1)
                            {
                                Console.WriteLine("分数修改为：");
                                int changedName = int.Parse(Console.ReadLine());
                                scoreService.StudenstList[index04].Score = changedName;
                            }
                            else
                                Console.WriteLine("查无此人！");
                            break;
                        case 5:
                            controller = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("输入有误！");

            }


        }


    }
}
