using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class Extensions
    {
        public static string Capitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
