namespace Patterns.Behavioural.Command.Abstractions
{
    /// <summary>
    /// The 'CommandBase' class.
    /// Declares an interface for executing an operation.
    /// </summary>
    public abstract class CommandBase
    {
        protected readonly IReceiver Service;

        protected CommandBase(IReceiver service)
            => Service = service;

        public abstract bool Execute();
    }
}
