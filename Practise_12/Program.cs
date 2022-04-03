using System;
using ClassLibrary;
namespace Practise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebenin FullName-i:");
            string fullname = Console.ReadLine();
            while(ExtentionMetods.CheckFullName(fullname)==false)
            {
                Console.WriteLine("Telebenin FullName-i:");
                fullname = Console.ReadLine();
            }
            Console.WriteLine("Telebenin GroupNo-si:");
            string groupno = Console.ReadLine();
            while (ExtentionMetods.CheckGroupNo(groupno) == false)
            {
                Console.WriteLine("Telebenin GroupNo-si:");
                groupno = Console.ReadLine();
            }
            Console.WriteLine("Telebenin yasi:");
            byte age = Convert.ToByte(Console.ReadLine());
            Student student = new Student(fullname,groupno,age);
            Console.WriteLine($"FullName:{student.FullName.Trim()}\nGroupNo:{student.GroupNo}\nAge:{student.Age}");
        }
    }
}
