using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Abstraction
{
    public abstract class HelpHandler
    {
        protected HelpHandler Successor { get; private set; }

        protected abstract string Key { get; }


        internal virtual void HandleHelp(string key)
            => Console.WriteLine($"There is no handler for '{key}' help key.");

        internal void SetSuccessor(HelpHandler successor)
            => Successor = successor;
    }
}
