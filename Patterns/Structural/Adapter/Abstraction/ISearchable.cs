namespace Patterns.Structural.Adapter.Abstraction
{
    /// <summary>
    /// The 'Target' interface.
    /// Defines the domain-specific interface that <see cref="Client"/> uses.
    /// </summary>
    public interface ISearchable
    {
        bool Contains(string source, string term);

        int GetHitsCount(string source, string term);
    }
}
