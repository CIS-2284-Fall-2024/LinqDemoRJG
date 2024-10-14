using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if (str == null)
            {
                return null;
            }
            else if (str.Length > 1)
            {
                return char.ToUpper(str[0])+str.Substring(1).ToLower();
            }
            else
            {
                return str.ToUpper();
            }
        }

        public static string ToTitleCase(this string str)
        {
            //Break the str into words
            string[] subs = str.Split(' ');

            string titleStr = "";
            //Capitalize each word and put it back to gether
            foreach (string s in subs)
            {
                titleStr += s.Capitalize() + " ";
            }
            return titleStr;
        }

    }
}
