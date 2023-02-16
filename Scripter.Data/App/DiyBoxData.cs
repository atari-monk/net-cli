namespace Scripter.Data;

public class DiyBoxData 
    : AllLibsData
{
    private const string Repo = "diy-box";

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        var diyBoxCore = SetProjectDepsAndTests(
            Repo
            , "DiyBox.Core"
            , SetTests(
                "DiyBox.Tests"
                , "DiyBox.Integration.Tests")
            , DIHelper
            , CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        Set(
            "diy-box-cli-app"
            , "DiyBox.ConsoleApp"
            , isApp: true
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , SerilogWrapper
            , CLIFramework
            , diyBoxCore);
        var diyBoxCmdDotNet = Set(
            Repo
            , "DiyBox.CommandDotNet");
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        Set(
            "diy-box-modern-cli-app"
            , "DiyBox.Modern.CliApp"
            , isApp: true
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , diyBoxCore
            , diyBoxCmdDotNet); 
    }
}