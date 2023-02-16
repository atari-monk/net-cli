using Scripter.Data;
using Unity;

namespace Scripter;

public class LogBuildAllSet 
    : ProjBuildAllSetBase
{
    public LogBuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterProjBuildAll<ConsoleLogData>(
            "ConsoleLibLog.BuildAll.ps1"
            , "Log.ConsoleApp");
        RegisterProjBuildAll<ModernMDILogData>(
            "ModernMDILog.BuildAll.ps1"
            , "Log.Modern.MDI.ConsoleApp");
        RegisterProjBuildAll<ModernWizardLogData>(
            "ModernLogWizard.BuildAll.ps1"
            , "Log.Modern.Wizard.ConsoleApp");
        RegisterProjBuildAll<ModernLogData>(
            "ModernLog.BuildAll.ps1"
            , "Log.Modern.ConsoleApp");
    }
}