namespace Scripter;

public class CompileScript : IScript
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

    public CompileScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"Set-Location -Path \"{scriptParam.RepoPath}\""
            , $"dotnet build"
            , $"dotnet build --configuration Release"
            , $"dotnet publish -c Release"
            , $"Set-Location -Path \"{scriptParam.ScriptPath}\""
        };
    }
}