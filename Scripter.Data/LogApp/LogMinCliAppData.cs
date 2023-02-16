namespace Scripter.Data;

public class LogMinCliAppData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        var logmindata = Set(
            "log-min-data"
            , "Log.Min.Data"
            , EFCoreHelper
            , ModelHelper
            );
        var logminlib = Set(
            "log-min-lib"
            , "Log.Min.Lib"
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , logmindata
            );
        var logmintable = Set(
            "log-min-table"
            , "Log.Min.Table"
            , DIHelper
            , ModelHelper
            , DataToTable
            , logmindata);
        var logmincliapp = SetProjectDepsAndTests(
            "log-min-cli-app"
            , "Log.Min.Cli.App"
            , isApp: true
            , SetTests(
                "Log.Min.Cli.App.TestApi"
                , "Log.Min.Cli.App.Tests")
            , EFCoreHelper
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , logmindata
            , logmintable
            , logminlib
            );
    }
}