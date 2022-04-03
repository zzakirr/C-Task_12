using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class ExtentionMetods
    {
        public static bool IsOdd(this int num)
        {
            if(num%2!=0)
                return true;
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }
        public static string IsCapitalize(this string str)
        {
            string str2 = str.Replace(str[0], char.ToUpper(str[0]));
            return str2;
        }
        public static int[] GetValueIndexes(this string str,char chr)
        {
            int count = 0;
            foreach (var item in str)
            {
                if(item == chr)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                int[] indexes1 = new int[0] { };
                return indexes1;
            }
            int[] indexes = new int[count];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == chr)
                {
                    indexes[j++] = i;
                }
            }
            return indexes;
        }
        public static bool CheckFullName(string fullname1)
        {
            string fullname = fullname1.Trim();
            if (fullname.Contains(" "))
            {
                int count = 0;
                foreach (var item in fullname)
                {
                    if(item==' ')
                    {
                        count++;
                    }
                }
                if(count == 1)
                {
                    string[] split = fullname.Split(" ");
                    if (char.IsUpper(split[0], 0) && char.IsUpper(split[1], 0))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        public static bool CheckGroupNo(string groupno)
        {
            if(groupno.Length==4)
            {
                if (char.IsUpper(groupno[0]) && char.IsDigit(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
