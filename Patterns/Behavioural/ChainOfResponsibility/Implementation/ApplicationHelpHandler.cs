using Patterns.Behavioural.ChainOfResponsibility.Abstraction;
using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Implementation
{
    public class ApplicationHelpHandler : HelpHandler
    {
        protected override string Key => "application";

        public override void HandleHelp(string key)
        {
            if (key == Key)
                Console.WriteLine($"{nameof(ApplicationHelpHandler)} help message.");
            else if (Successor != null)
                Successor.HandleHelp(key);
            else
                base.HandleHelp(key);
        }
    }
}
