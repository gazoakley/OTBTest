using System;
using System.Data.Common;

namespace Salary.Formatting
{
    interface IFormatter
    {
        String Format(DbDataReader reader);
    }
}
