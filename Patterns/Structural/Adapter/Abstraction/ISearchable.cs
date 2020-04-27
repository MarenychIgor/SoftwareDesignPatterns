namespace Patterns.Structural.Adapter.Abstraction
{
    // Public interface for some third party code. 
    public interface ISearchable
    {
        bool Contains(string source, string term);

        int GetHitsCount(string source, string term);
    }
}
