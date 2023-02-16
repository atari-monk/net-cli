using DIHelper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public class AppCommandSet
    : UnityDependencySet
{
    public AppCommandSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterReadCommands();
    }

    private void RegisterReadCommands()
    {
    }
}