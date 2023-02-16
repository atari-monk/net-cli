using System.Windows.Input;
using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class AppCommands 
    : UnityDependencySet
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}