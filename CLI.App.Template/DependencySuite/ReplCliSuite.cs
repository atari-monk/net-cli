using CommandDotNet.Unity.Helper;
using DIHelper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public class ReplCliSuite 
    : UnityDependencySuite
{
    public ReplCliSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterCommands() => 
        RegisterSet<AppCommandSet>();

    protected override void RegisterProgram() =>
        RegisterSet<AppProgSet<ReplCli>>();
}