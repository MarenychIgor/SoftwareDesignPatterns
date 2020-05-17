using Patterns.Behavioural.Command.Abstractions;
using System.Linq;

namespace Patterns.Behavioural.Command.Implementation
{
    /// <summary>
    /// The 'Receiver' class.
    /// Knows how to perform the operations associated with carrying out the request.
    /// </summary>
    public class ValidatonService : IReceiver
    {
        public bool Action(params object[] parameters)
        {
            if (parameters.First() is string login && parameters.Last() is string password)
                return Validate(login, password);

            return false;
        }

        private bool Validate(string login, string password)
            => !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
    }
}
