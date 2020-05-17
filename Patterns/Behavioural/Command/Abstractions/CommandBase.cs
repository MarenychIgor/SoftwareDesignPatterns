using Patterns.Behavioural.Command.Implementation;

namespace Patterns.Behavioural.Command.Abstractions
{
    /// <summary>
    /// The 'CommandBase' class.
    /// Declares an interface for executing an operation.
    /// </summary>
    public abstract class CommandBase
    {
        protected readonly ValidatonService Service;

        protected CommandBase(ValidatonService service)
            => Service = service;

        public abstract bool Execute();
    }
}
