using System.Text;

namespace Scripter;

public class CloneScript
    : IScript
{
    private readonly StringBuilder sb;
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Clone.ps1";
        }
    }

    public CloneScript(
        IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        sb = new StringBuilder();
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        Reset();
        AddParamsSection();
        AddScriptBodySection();
        return GetLines();
    }

    private void AddParamsSection()
    {
        ArgumentNullException.ThrowIfNull(
            scriptParam.Project);
        AddFormatLine("$repoPath = \"{0}\"{1}"
            , scriptParam.RepoPath);
        AddFormatLine("$codePath = \"{0}\"{1}"
            , scriptParam.CodePath);
        AddFormatLine("$scriptPath = \"{0}\"{1}"
            , scriptParam.ScriptPath);
        AddFormatLine("$proj = \"{0}\"{1}"
            , scriptParam.Project.RepoFolder);
        AddFormatLine("$http = \"{0}\"{1}"
            , scriptParam.CloneUrlStart);
        AddFormatLine("$end = \"{0}\"{1}"
            , scriptParam.CloneUrlEnd);
        AddLine("$url = $http + $proj + $end");
    }

    private void AddScriptBodySection()
    {
        AddLine("if(-not (Test-Path $repoPath))");
        AddLine("{");
        AddLine("	Set-Location $codePath");
        AddLine("	$result = git clone $url");
        AddLine("	Write-Output \"$proj - $result\"");
        AddLine("}");
        AddLine("else");
        AddLine("{");
        AddLine("	Write-Output \"$proj - Repo already cloned\"");
        AddLine("}");
        AddLine("Set-Location $scriptPath");
    }

    private string[] GetLines()
    {
        return sb.ToString().Split(Environment.NewLine);
    }

    private void Reset()
    {
        sb.Clear();
    }

    private void AddFormat(
        string format
        , params string[] args)
    {
        sb.AppendFormat(format, args);
    }

    private void AddFormatLine(
        string format
        , params string[] args)
    {
        var list = new List<string>(args);
        list.Add(Environment.NewLine);
        AddFormat(format, list.ToArray());
    }

    private void Add(
        string text)
    {
        sb.Append(text);
    }

    private void AddLine(
        string text)
    {
        sb.AppendLine(text);
    }
}