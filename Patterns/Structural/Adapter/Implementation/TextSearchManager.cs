using System.Text.RegularExpressions;

namespace Patterns.Structural.Adapter.Implementation
{
    public class TextSearchManager
    {
        public string Term { get; set; }

        public int IndexOf(string source)
            => source.IndexOf(Term);

        public int GetEntriesCount(string source)
            => Regex.Matches(source, Term).Count;
    }
}
