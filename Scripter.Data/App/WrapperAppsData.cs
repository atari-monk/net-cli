namespace Scripter.Data;

public class WrapperAppsData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        var configTestApp = Set(
            "config-wrapper"
            , "Config.Wrapper.CLI.TestApp"
            , isApp: true
        );
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        var serilogTestApp = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper.CLI.TestApp"
            , isApp: true
            , ConfigWrapper
        );
    }
}