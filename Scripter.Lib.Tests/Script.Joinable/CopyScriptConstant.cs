namespace Scripter.Lib.Tests;

public abstract class CopyScriptConstant
{
    protected const string RootPath = @"C:\atari-monk";
    protected const string BuildPath = @$"{RootPath}\Build";
    protected const string CodePath = @$"{RootPath}\Code";
    protected const string RepoFolder = "cli-helper";
    protected const string RepoBuildPath = @$"{BuildPath}\{RepoFolder}";
    protected const string AppProjFolder = "CLIHelper";
    protected const string AppBuildPath = $@"{RepoBuildPath}\{AppProjFolder}";
    protected const string SourcePath = @$"{CodePath}\{RepoFolder}\{AppProjFolder}\bin\Release\net6.0\publish\*";
    protected const string WpfProjSourcePath = @$"{CodePath}\{RepoFolder}\{AppProjFolder}\bin\Release\net6.0-windows\publish\*";
}