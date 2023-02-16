using Scripter.Data.Helper;

namespace Scripter;

public interface IScriptParam
{
    ProjectDTO? Project { get; set; }
    string XmlVersionFile { get; }
    string CsvVersionFile { get; }
    string VersionFilePath { get; }
    string CopyAppScript { get; }
    string CodePath { get; }
    string BuildPath { get; }
    string ProjBuildPath { get; }
    string AppsPath { get; }
    string AppPath { get; }
    string RepoPath { get; }
    string ScriptPath { get; }
    string CloneUrlStart { get; }
    string CloneUrlEnd { get; }
    string CloneUrl { get; }
}