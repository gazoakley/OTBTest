using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

using Salary.Extensions;
using Salary.Properties;

namespace Salary.Formatting
{
    class DisplayFormatter : IFormatter
    {
        public String Format(DbDataReader results)
        {
            var output = new StringBuilder();

            // Output headings
            var fieldNames = results.GetFieldNames().Select(n => n.ToTitleCase()).ToArray();
            var fieldLines = fieldNames.Select(n => new String('-', n.Length)).ToArray();
            output.AppendFormat(Settings.Default.Format, fieldNames);
            output.AppendLine();
            output.AppendFormat(String.Format(Settings.Default.Format, fieldLines));
            output.AppendLine();

            // Enumerate records
            while (results.Read())
            {
                output.AppendFormat(Settings.Default.Format, results.GetFieldValues().ToArray());
                output.AppendLine();
            }

            return output.ToString();
        }
    }
}
