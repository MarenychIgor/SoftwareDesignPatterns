using Patterns.Behavioural.Command.Abstractions;

namespace Patterns.Behavioural.Command.Implementation
{
    /// <summary>
    /// The 'Invoker' class.
    /// Asks the <see cref="CommandBase"/> to carry out the request.
    /// </summary>
    public class Invoker
    {
        private CommandBase _command;

        public void SetCommand(CommandBase command)
            => _command = command;

        public bool ExecuteCommand()
            => _command.Execute();
    }
}
