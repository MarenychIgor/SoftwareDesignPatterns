using Patterns.Behavioural.ChainOfResponsibility.Implementation;

namespace Patterns.Behavioural.ChainOfResponsibility
{
    public class Client
    {       
        public void ShowHelpMessage()
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
