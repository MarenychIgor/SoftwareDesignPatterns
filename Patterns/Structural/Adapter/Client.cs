using Patterns.Structural.Adapter.Abstraction;

namespace Patterns.Structural.Adapter
{
    /// <summary>
    /// The 'Client' class.
    /// Collaborates with objects conforming to the <see cref="ISearchable"/> interface.
    /// </summary>
    public class Client
    {
        private readonly ISearchable _searchManager;

        public Client(ISearchable searchManager)
            => _searchManager = searchManager;

        public bool Contains(string source, string term)
            => _searchManager.Contains(source, term);

        public int GetHitsCount(string source, string term)
            => _searchManager.GetHitsCount(source, term);
    }
}
