namespace Scripter.Data;

public class SampleAppsData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        var commanddotnetexamples = SetProjAndTests(
            "commanddotnet-examples"
            , "CommandDotNet.Examples.App"
            , isApp: true
            , SetTest("CommandDotNet.Examples.Tests")
        );
    }
}