using Scripter.Data.Helper;

namespace Scripter;

public class ScriptParam 
    : IScriptParam
{
    private const string RootPath = @"C:\atari-monk";
    private const string CodeFolder = "Code";
    private const string VersionXmlFile = "Version.xml";
    private const string VersionCsvFile = "Version.csv";
    private const string GitHubUrlEnd = ".git";
    private const string GitHubStart = @"https://github.com/atari-monk/";
    private const string BuildFolder = "Build";
    private const string BuildScriptFolder = "Build.Script";
    private const string AppsFolder = "Apps";
    private const string CopyAppPost = ".CopyApp.ps1";

    public ProjectDTO? Project { get; set; }

    public string XmlVersionFile => VersionXmlFile;

    public string CsvVersionFile => VersionCsvFile;

    public string VersionFilePath => Path.Combine(BuildPath, VersionCsvFile);

    public string CodePath => Path.Combine(RootPath, CodeFolder);

    public string BuildPath => Path.Combine(RootPath, BuildFolder);

    public string AppsPath => Path.Combine(RootPath, AppsFolder);

    public string CopyAppScript
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return $"{Project.ProjFolder}.CopyApp.ps1";
        }
    }

    public string RepoPath
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                CodePath
                , Project.RepoFolder);
        }
    }

    public string ProjBuildPath
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                BuildPath
                , Project.RepoFolder
                , Project.ProjFolder);
        }
    }

    public string AppPath
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                AppsPath
                , Project.ProjFolder);
        }
    }

    public string ScriptPath => Path.Combine(RootPath, BuildScriptFolder);

    public string CloneUrlStart => GitHubStart;
    
    public string CloneUrlEnd => GitHubUrlEnd;
    
    public string CloneUrl
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                CloneUrlStart
                , Project.RepoFolder + CloneUrlEnd);
        }
    }
}