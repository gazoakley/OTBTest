using CommandLine;
using CommandLine.Text;

namespace Salary
{
    class Options
    {
        [VerbOption("search", HelpText = "Search for employees by name")]
        public SearchOptions SearchVerb { get; set; }

        [VerbOption("role", HelpText = "List employees by role")]
        public RoleOptions RoleVerb { get; set; }

        [HelpVerbOption]
        public string GetUsage(string verb)
        {
            return HelpText.AutoBuild(this, verb);
        }
    }

    class SearchOptions
    {
        [ValueOption(0)]
        public string Name { get; set; }
    }

    class RoleOptions
    {
        [ValueOption(0)]
        public string Role { get; set; }
    }
}
