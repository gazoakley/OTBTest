using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Salary.Extensions
{
    public static class DbDataReaderExtensions
    {
        public static IEnumerable<String> GetFieldNames(this DbDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                yield return reader.GetName(i);
            }
        }

        public static IEnumerable<String> GetFieldValues(this DbDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                yield return reader.GetValue(i).ToString();
            }
        }
    }
}
