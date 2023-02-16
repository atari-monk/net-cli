namespace Scripter;

public class PullScript
    : IScript
{
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Pull.ps1";
        }
    }

    public PullScript(
        IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        return new string[]
        {
            $"$repoPath = \"{scriptParam.RepoPath}\""
            , $"$scriptPath = \"{scriptParam.ScriptPath}\""
            , $"$proj = \"{scriptParam.Project.RepoFolder}\""
            , "if(-not (Test-Path $repoPath))"
            , "{"
            , "    Write-Output \"No path: $repoPath\""
            , "}"
            , "else"
            , "{"
            , "   Set-Location $repoPath"
            , "   $result = git pull"
            , "   Write-Output \"$proj - $result\""
            , "}"
            , "Set-Location $scriptPath"
        };
    }
}