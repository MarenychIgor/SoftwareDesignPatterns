using Patterns.Behavioural.ChainOfResponsibility.Abstraction;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Implementation
{
    /// <summary>
    /// The 'ConcreteHandler' class.
    /// If the ConcreteHandler can handle the request, it does so.
    /// Otherwise it forwards the request to its successor.
    /// </summary>
    public class ApplicationHelpHandler : HelpHandler
    {
        protected override string Key => "application";

        public override void HandleHelp(string key)
        {
            if (key == Key)
                Console.WriteLine($"{nameof(ApplicationHelpHandler)} help message.");
            else if (Successor != null)
                Successor.HandleHelp(key);
        }
    }
}
