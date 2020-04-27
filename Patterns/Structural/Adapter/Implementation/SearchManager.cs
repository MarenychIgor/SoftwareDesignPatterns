﻿using Patterns.Structural.Adapter.Abstraction;

namespace Patterns.Structural.Adapter.Implementation
{
    public class SearchManager : ISearchable
    {
        private readonly TextSearchManager _manager;

        public SearchManager(TextSearchManager manager)
            => _manager = manager;

        public bool Contains(string source, string term)
        {
            _manager.Term = term;
            return _manager.IndexOf(source) > default(int);
        }

        public int GetHitsCount(string source, string term)
        {
            _manager.Term = term;
            return _manager.GetEntriesCount(source);
        }
    }
}
