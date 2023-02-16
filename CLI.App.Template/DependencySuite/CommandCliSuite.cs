using CommandDotNet.Helper;
using CommandDotNet.Unity.Helper;
using Config.Wrapper;
using DIHelper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public class CommandCliSuite 
    : UnityDependencySuite
{
    public CommandCliSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterCommands() => 
        RegisterSet<AppCommandSet>();

    protected override void RegisterProgram() =>
        RegisterSet<AppProgSet<CommandCli>>();
}