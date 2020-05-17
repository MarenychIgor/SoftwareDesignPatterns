namespace Patterns.Behavioural.Command.Abstractions
{
    public interface IReceiver
    {
        public bool Action(params object[] parameters);
    }
}
