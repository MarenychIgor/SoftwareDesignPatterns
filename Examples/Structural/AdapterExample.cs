using Patterns.Structural.Adapter.Implementation;

namespace Examples.Structural
{
    public class AdapterExample
    {
        public void RunExample()
        {
            var adaptee = new TextSearchManager();
            var adapter = new SearchManager(adaptee);

            var source = "String to search";
            var firstSearchTerm = "to";
            var secondSearchTerm = "t";

            var contains = adapter.Contains(source, firstSearchTerm);
            var hitsCount = adapter.GetHitsCount(source, secondSearchTerm);
        }
    }
}
