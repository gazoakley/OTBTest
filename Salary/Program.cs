using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

using CommandLine;

using Salary.Formatting;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse command line options
            var options = new Options();
            string invokedVerb = null; object invokedOptions = null;
            Parser.Default.ParseArguments(args, options, (verb, suboptions) =>
            {
                invokedVerb = verb;
                invokedOptions = suboptions;
            });

            // Check verb specified
            if (invokedOptions == null)
            {
                return;
            }

            // Invoke reporter
            var reporter = new SalaryReporter();
            var formatter = new DisplayFormatter();
            Console.Write(reporter.RunReport(invokedVerb, options, formatter));
        }
    }
}
