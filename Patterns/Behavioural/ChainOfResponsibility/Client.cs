using Patterns.Behavioural.ChainOfResponsibility.Implementation;

namespace Patterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// The 'Client' class.
    /// Initiates the request to a 'ConcreteHandler' object on the chain.
    /// </summary>
    public class Client
    {
        public void SendRequestToChain()
        {
            var form = new FormHelpHandler();
            var catalog = new CatalogHelpHandler();
            var application = new ApplicationHelpHandler();

            form.SetSuccessor(catalog);
            catalog.SetSuccessor(application);

            form.HandleHelp("form");
            form.HandleHelp("catalog");
            form.HandleHelp("application");
            form.HandleHelp("someKey");
        }
    }
}
