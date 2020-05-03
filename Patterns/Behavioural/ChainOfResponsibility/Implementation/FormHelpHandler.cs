using Patterns.Behavioural.ChainOfResponsibility.Abstraction;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Implementation
{
    /// <summary>
    /// The 'ConcreteHandler' class.
    /// If the ConcreteHandler can handle the request, it does so.
    /// Otherwise it forwards the request to its successor.
    /// </summary>
    public class FormHelpHandler : HelpHandler
    {
        protected override string Key => "form";

        public override void HandleHelp(string key)
        {
            if (key == Key)
                Console.WriteLine($"{nameof(FormHelpHandler)} help message.");
            else if (Successor != null)
                Successor.HandleHelp(key);
        }
    }
}
