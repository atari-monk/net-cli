namespace Scripter.Data;

public class TestAppsData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        var cliFrameworkTestApp =  Set(
            "cli-framework"
            , "CLIFramework.TestApp"
            , isApp: true
            , DIHelper
            , CLIHelper
            , DataToTable
            , ModelHelper
            , CLIReader);
        var betterConsoleTableTestApp =  Set(
            "better-console-tables-wrapper"
            , "Better.Console.Tables.TestApp"
            , isApp: true
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper);
    }
}