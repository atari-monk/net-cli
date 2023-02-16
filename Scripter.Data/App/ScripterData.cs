namespace Scripter.Data;

public class ScripterData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        var scripter = SetProjectDepsAndTests(
            repo: "scripter"
            , project: "Scripter"
            , isApp: true
            , SetTests("Scripter.Lib.Tests")
            , DIHelper
            , ConfigWrapper
            , DataToTable
            , CommandDotNetUnityHelper
            , CommandDotNetHelper
            , SerilogWrapper
            );
    }
}