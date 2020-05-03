using Patterns.Structural.Adapter;
using Patterns.Structural.Adapter.Implementation;

namespace Examples.Structural
{
    public class AdapterExample
    {
        public void RunExample()
        {
            var adapter = new SearchManager(new TextSearchManager());
            var client = new Client(adapter);

            var source = "String to search";
            var firstSearchTerm = "to";
            var secondSearchTerm = "t";

            var contains = client.Contains(source, firstSearchTerm);
            var hitsCount = client.GetHitsCount(source, secondSearchTerm);
        }
    }
}
