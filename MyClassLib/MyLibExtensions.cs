using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib
{
    public static class MyLibExtensions
    {
        public static bool IsOdd(this int i)
        {
            return i % 2 == 0;
        }
        public static int CountChar(this string str,char theLetter)
        {
            int count = 0;
            string[] parts = str.Split(" ");
            foreach(string s in parts){
                char[] let = s.ToLower().ToCharArray();
                foreach(char st in let)
                {
                    if (st.Equals(theLetter))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

}
