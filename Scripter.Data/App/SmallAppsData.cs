namespace Scripter.Data;

public class SmallAppsData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        Set(
            "refactor-app"
            , "Refactor.App"
            , isApp: true
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper);
        SetProjectDepsAndTests(
            "git-path"
            , "GitPath.ConsoleApp"
            , isApp: true
            , SetTests("GitPath.Tests")
            , DIHelper);
    }
}