using Scripter.Data;
using Unity;

namespace Scripter;

public class ProjBuildAllSet 
    : ProjBuildAllSetBase
{
    public ProjBuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterProjBuildAll<ScripterData>(
            "Scripter.BuildAll.ps1"
            , "Scripter");
        RegisterProjBuildAll<AppStarterData>(
            "AppStarter.BuildAll.ps1"
            , "AppStarter.ConsoleApp");
        RegisterProjBuildAll<DiyBoxData>(
            "DiyBox.BuildAll.ps1"
            , "DiyBox.ConsoleApp");
        RegisterProjBuildAll<DiyBoxData>(
            "DiyBox.Modern.CliApp.BuildAll.ps1"
            , "DiyBox.Modern.CliApp");
        RegisterProjBuildAll<GameData>(
            "GameData.BuildAll.ps1"
            , "GameData.ConsoleApp");
    }
}