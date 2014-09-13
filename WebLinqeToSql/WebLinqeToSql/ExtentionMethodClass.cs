using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinqeToSql
{
    public static class ExtentionMethodClass
    {
        public static string ChangefristletterCase(this string input)
        {
            char[] charlist = input.ToCharArray();
            if(input.Length > 0)
            { 
                charlist[0] = char.IsUpper(charlist[0]) ? char.ToLower(charlist[0]) : char.ToUpper(charlist[0]);
            }
            return new string(charlist);
        }
    }
}