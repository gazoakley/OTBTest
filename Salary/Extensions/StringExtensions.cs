using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string snakeCase)
        {
            var parts = snakeCase.Split('_');
            return String.Join(" ", parts.Select(p => p.ToInitialCase()));
        }

        public static string ToInitialCase(this string value)
        {
            if (value.Length > 0)
            {
                return value.Substring(0, 1).ToUpper() + value.Substring(1);
            }
            return value;
        }
    }
}
