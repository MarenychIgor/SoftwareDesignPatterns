using Patterns.Behavioural.Command.Abstractions;

namespace Patterns.Behavioural.Command.Implementation
{
    /// <summary>
    /// The 'ConcreteCommand' class.
    /// Defines a binding between a 'Receiver' object <see cref="ValidatonService"/> and an action.
    /// Implements Execute by invoking the corresponding operation(s) on 'Receiver'.
    /// </summary>
    public class ValidateCommand : CommandBase
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public ValidateCommand(ValidatonService service) : base (service)
        {
        }

        public override bool Execute()
            => Service.Validate(Login, Password);
    }
}
