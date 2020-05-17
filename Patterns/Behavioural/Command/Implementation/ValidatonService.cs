namespace Patterns.Behavioural.Command.Implementation
{
    /// <summary>
    /// The 'Receiver' class.
    /// Knows how to perform the operations associated with carrying out the request.
    /// </summary>
    public class ValidatonService
    {
        public bool Validate(string login, string password)
            => !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
    }
}
