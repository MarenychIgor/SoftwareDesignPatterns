using Patterns.Behavioural.ChainOfResponsibility.Abstraction;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Implementation
{
    public class FormHelpHandler : HelpHandler
    {
        protected override string Key => "form";

        internal override void HandleHelp(string key)
        {
            if (key == Key)
                Console.WriteLine($"{nameof(FormHelpHandler)} help message.");
            else if (Successor != null)
                Successor.HandleHelp(key);
            else        
                base.HandleHelp(key);
        }
    }
}
