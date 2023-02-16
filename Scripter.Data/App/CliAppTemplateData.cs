namespace Scripter.Data;

public class CliAppTemplateData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        Set(
            "modern-cli-app-template"
            , "CLI.App.Template"
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper
            );
    }
}