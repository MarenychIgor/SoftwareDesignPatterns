using Patterns.Behavioural.Command.Implementation;

namespace Examples.Behavioural
{
    /// <summary>
    /// The 'Client' class.
    /// Creates a <see cref="ValidateCommand"/> object and sets its receiver.
    /// </summary>
    public class CommandExample
    {
        public void RunExample()
        {
            var invoker = new Invoker();
            var receiver = new ValidatonService();
            var command = new ValidateCommand(receiver)
            {
                Login = "login", 
                Password = "password"
            };

            invoker.SetCommand(command);
            var isValid = invoker.ExecuteCommand();
        }
    }
}
