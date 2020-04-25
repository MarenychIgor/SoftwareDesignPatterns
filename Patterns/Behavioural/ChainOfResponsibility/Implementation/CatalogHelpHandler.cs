using Patterns.Behavioural.ChainOfResponsibility.Abstraction;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Implementation
{
    public class CatalogHelpHandler : HelpHandler
    {
        protected override string Key => "catalog";

        internal override void HandleHelp(string key)
        {
            if (key == Key)
                Console.WriteLine($"{nameof(CatalogHelpHandler)} help message.");
            else if (Successor != null)
                Successor.HandleHelp(key);
            else
                base.HandleHelp(key);
        }
    }
}
