using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework03_4
{
    class PersonService
    {
        ArrayList persons = new ArrayList();
        // 使用属性封装字段
        public ArrayList Persons
        {
            get
            {
                return persons;
            }
        }
        //增加人员
        public void AddPerson(string name)
        {
            persons.Add(name);
        }
        //利用Cantains()查找人员  忽略重名
        public bool FindPerson(string name)
        {
            if (persons.Contains(name))
            {
                return true;
            }
            return false;
        }
        //Remove()删除人员  忽略重名
        public bool RemovePerson(string name)
        {
            if (persons.Contains(name))
            {
                persons.Remove(name);
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new PersonService();
            //添加6个人员记录
            for (int i = 0; i < 6; i++)
            {
                string name = "银河" + (i + 1) + "号";
                personService.AddPerson(name);
            }
            //打印人员记录
            Console.Write("人员名单：");
            foreach (Object obj in personService.Persons)
                Console.Write(obj + "  ");

            //实例展示增加、查询、删除人员
            Console.WriteLine();
            Console.WriteLine("是否存在银河3号：" + personService.FindPerson("银河3号"));
            Console.WriteLine("删除银河3号");
            personService.RemovePerson("银河3号");
            Console.WriteLine("是否存在银河3号：" + personService.FindPerson("银河3号"));
            Console.Write("人员名单：");
            foreach (Object obj in personService.Persons)
                Console.Write(obj + "  ");

            //输入查询  其余操作在作业5中重点实现
            Console.WriteLine();
            Console.Write("输入查询人姓名：");
            string input = Console.ReadLine();
            Console.WriteLine("是否存在{0}：{1}  ", input, personService.FindPerson(input));

        }
    }
}
