using Patterns.Behavioural.ChainOfResponsibility;

namespace Examples.Behavioural
{
    public class ChainOfResponsibilityExample
    {
        public void RunExample()
        {
            var client = new Client();
            client.SendRequestToChain();
        }
    }
}
