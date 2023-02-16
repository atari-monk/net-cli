using Scripter.Data.Helper;

namespace Scripter.Data;

public class AppStarterData 
    : AllLibsData
{
    private const string Repo = "app-starter";
    private ProjectDTO? appStarterData;
    private ProjectDTO? appStarterModernLib;
    private ProjectDTO? appStarterCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        appStarterData = Set(
            Repo
            , "AppStarter.Data"
            , EFCoreHelper
            , ModelHelper
            );
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DotNetTool);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        appStarterModernLib = Set(
            Repo
            , "AppStarter.Lib"
            , EFCoreHelper
            , DotNetTool
            , CLIHelper
            , ModelHelper
            , CLIReader
            , DataToTable
            , CLIFramework
            );
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        appStarterCLIApp = Set(
            Repo
            , "AppStarter.ConsoleApp"
            , isApp: true
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , DotNetTool
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , CLIReader
            , DataToTable
            , SerilogWrapper
            , CLIFramework
            , appStarterData
            , appStarterModernLib
            );
    }
}