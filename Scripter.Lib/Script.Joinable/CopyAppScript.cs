namespace Scripter;

public class CopyAppScript
    : IScript
{
    private readonly IScriptParam data;

    public string File => data.CopyAppScript;

    public CopyAppScript(IScriptParam data)
    {
        this.data = data;
        ArgumentNullException.ThrowIfNull(this.data);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(data.Project);
        return new string[]
        {
            $"$projBuildPath = \"{data.ProjBuildPath}\""
            , $"$appsPath = \"{data.AppsPath}\""
            , $"$projBuildPathAll = \"{data.ProjBuildPath}\\*\""
            , $"$appPath = \"{data.AppPath}\""
            , $"$versionFilePath = \"{data.VersionFilePath}\""
            , "Copy-Item -Path $projBuildPath -Destination $appsPath -Force"
            , "Copy-Item -Path $projBuildPathAll -Destination $appPath -Recurse -Force"
            , "Copy-Item -Path $versionFilePath -Destination $appsPath -Force"
        };
    }
}