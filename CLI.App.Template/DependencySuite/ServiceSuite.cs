using Config.Wrapper.Unity;
using DIHelper.Unity;
using Serilog.Wrapper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public class ServiceSuite 
    : UnityDependencySuite
{
    public ServiceSuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<SerilogSet>();
        RegisterSet<AppConfigSet>();  
    }
}