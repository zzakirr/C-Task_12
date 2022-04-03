using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student(string fullname,string groupno,byte age)
        {
            FullName = fullname;
            GroupNo = groupno;
            Age = age;
        }
        public string FullName;
        public string GroupNo;
        public byte Age;
        
    }
}
