using System;

namespace Patterns.Behavioural.ChainOfResponsibility.Abstraction
{
    public abstract class HelpHandler
    {
        protected HelpHandler Successor { get; private set; }

        protected abstract string Key { get; }


        public virtual void HandleHelp(string key)
            => Console.WriteLine($"There is no handler for '{key}' help key.");

        public void SetSuccessor(HelpHandler successor)
            => Successor = successor;
    }
}
