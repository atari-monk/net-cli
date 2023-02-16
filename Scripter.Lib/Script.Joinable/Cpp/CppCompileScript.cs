namespace Scripter;

public class CppCompileScript
    : IScript
{
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Compile.ps1";
        }
    }

    public CppCompileScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(this.scriptParam.Project);
        return new string[]
        {
            $"Set-Location -Path \"{scriptParam.RepoPath}\""
            , $"mingw32-make"
            , $"Set-Location -Path \"{scriptParam.ScriptPath}\""
        };
    }
}