using Patterns.Behavioural.ChainOfResponsibility.Implementation;

namespace Examples.Behavioural
{
    public class ChainOfResponsibilityExample
    {
        public void RunExample()
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
