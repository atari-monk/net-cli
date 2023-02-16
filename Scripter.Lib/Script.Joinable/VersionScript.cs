namespace Scripter;

public class VersionScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Version.ps1";
        }
    }

    public VersionScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        return new string[]
        {
            $"$projectName = \"{scriptParam.Project.ProjFolder}\""
            , $"$versionFileName = \"{scriptParam.XmlVersionFile}\""
            , $"$buildPath = \"{scriptParam.BuildPath}\""
            , $"$scriptPath = \"{scriptParam.ScriptPath}\""
            , $"$repoPath = \"{scriptParam.RepoPath}\""
            , ""
            , $"Set-Location -Path $repoPath"
            , $"$sh1 = git rev-parse HEAD"
            , ""
            , $"Set-Location -Path $buildPath"
            , $"$versionFilePath = $buildPath + \"\\\" + $versionFileName"
            , "if (-not (Test-Path $versionFilePath))"
            , "{"
            , "$hashTable = @{}"
            , "$hashTable.Add($projectName, $sh1)"
            , "}"
            , "else"
            , "{"
            , $"$hashTable = Import-Clixml $versionFilePath"
            , $"$hashTable[$projectName] = $sh1"
            , "}"
            , $"$hashTable | Export-Clixml -Path $versionFilePath"
            , "$versionFilePathCsv = $buildPath + \"\\Version.csv\""
            , "$hashTable.GetEnumerator() |"
            , "Select-Object -Property @{N='Property';E={$_.Key}},"
            , "@{N='PropValue';E={$_.Value}} |"
            , "Export-Csv -NoTypeInformation -Path $versionFilePathCsv"
            , $"Set-Location -Path $scriptPath"
        };
    }
}