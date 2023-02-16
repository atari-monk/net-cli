namespace Scripter;

public class CopyBuildScript
    : IScript
{
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Copy.ps1";
        }
    }

    public CopyBuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        var repoFolder = scriptParam.Project.RepoFolder;
        var appFolder = scriptParam.Project.ProjFolder;
        var buildPath = scriptParam.BuildPath;
        var repoPath = scriptParam.RepoPath;
        var repoBuildPath = Path.Combine(buildPath, repoFolder);
        var appProjPath = Path.Combine(repoPath, appFolder);
        var appProjBuildPath = Path.Combine(buildPath, repoFolder, appFolder);
        return new string[]
        {
            $"$path = \"{repoBuildPath}\""
            , "if (-not (Test-Path $path))"
            , "{"
            , $"New-Item -Path \"{buildPath}\" -Name \"{repoFolder}\" -ItemType \"directory\""
            , "}"
            , $"$path = \"{appProjBuildPath}\""
            , "if (-not (Test-Path $path))"
            , "{"
            , $"New-Item -Path \"{repoBuildPath}\" -Name \"{appFolder}\" -ItemType \"directory\""
            , "}"
            , "else"
            , "{"
            , $"Remove-Item \"{appProjBuildPath}\\*\" -Recurse"
            , "}"
            , $"Copy-Item -Path \"{appProjPath}\\bin\\Release\\{GetNetVer()}\\publish\\*\" "
                + $"-Destination \"{appProjBuildPath}\" -Recurse"
        };
    }

    protected virtual string GetNetVer() => "net6.0";
}