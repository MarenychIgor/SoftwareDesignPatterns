namespace Patterns.Behavioural.ChainOfResponsibility.Abstraction
{
    /// <summary>
    /// The 'Handler' abstract class.
    /// Defines an interface for handling the requests.
    /// Implements the successor link (optional).
    /// </summary>
    public abstract class HelpHandler
    {
        protected HelpHandler Successor { get; private set; }

        protected abstract string Key { get; }

        public void SetSuccessor(HelpHandler successor)
            => Successor = successor;

        public abstract void HandleHelp(string key);
    }
}
