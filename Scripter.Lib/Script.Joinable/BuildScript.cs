namespace Scripter;

public class BuildScript 
    : IScript
{
    private readonly IScriptParam scriptParam;
    private string? projName;

    protected string? ProjName => projName;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Build.ps1";
        }
    }

    public BuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(this.scriptParam.Project);
        projName = this.scriptParam.Project.ProjFolder;
        return GetScriptContent();
    }

    protected virtual string[] GetScriptContent()
    {
        return new string[]
        {
            $"& \"$PSScriptRoot\\{projName}.Clone.ps1\""
            , $"& \"$PSScriptRoot\\{projName}.Pull.ps1\""
            , $"& \"$PSScriptRoot\\{projName}.Test.ps1\""
            , $"& \"$PSScriptRoot\\{projName}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{projName}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{projName}.Copy.ps1\""
        };
    }
}