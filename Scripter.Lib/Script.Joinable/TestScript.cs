using Scripter.Data.Helper;

namespace Scripter;

public class TestScript : IScript
{
    private readonly IScriptParam scriptParam;
    private readonly List<string> lines;

    public string File
    {
        get
        {
            return $"{scriptParam.Project!.ProjFolder}.Test.ps1";
        }
    }

    public TestScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        lines = new List<string>();
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(this.scriptParam.Project);
        if(this.scriptParam.Project.Tests is null) 
            return Array.Empty<string>();
        lines.Clear();
        foreach (var test in scriptParam.Project.Tests)
        {
            GetTest(test);
        }
        lines.Add($"Set-Location -Path \"{scriptParam.ScriptPath}\"");
        return lines.ToArray();
    }

    private void GetTest(ProjectDTO test)
    {
        lines.Add($"Set-Location -Path \"{Path.Combine(scriptParam.RepoPath, test.ProjFolder)}\"");
        lines.Add("dotnet test");
    }
}