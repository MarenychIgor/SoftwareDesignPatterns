using System.Text.RegularExpressions;

namespace Patterns.Structural.Adapter.Implementation
{
    /// <summary>
    /// The 'Adaptee' class.
    /// Defines an existing interface that needs adapting.
    /// </summary>
    public class TextSearchManager
    {
        public string Term { get; set; }

        public int IndexOf(string source)
            => source.IndexOf(Term);

        public int GetEntriesCount(string source)
            => Regex.Matches(source, Term).Count;
    }
}
