using System;
using Scripter.Data.Helper;

namespace Scripter.Lib.Tests;

public abstract class ScriptParamTestBase
{
    public abstract void TestParams(
        string propName
        , string expected);

    protected IScriptParam GetSut()
    {
        return new ScriptParam
        {
            Project = new ProjectDTO(
                RepoFolder: "cli-helper"
                , ProjFolder: "CLIHelper")
        };
    }

    protected string SelectProp(
        IScriptParam scriptParam
        , string name)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        switch(name)
        {
            case nameof(ScriptParam.Project.RepoFolder):
                return scriptParam.Project.RepoFolder;
            case nameof(ScriptParam.Project.ProjFolder):
                return scriptParam.Project.ProjFolder;
            case nameof(ScriptParam.XmlVersionFile):
                return scriptParam.XmlVersionFile;
            case nameof(ScriptParam.CodePath):
                return scriptParam.CodePath;
            case nameof(ScriptParam.BuildPath):
                return scriptParam.BuildPath;
            case nameof(ScriptParam.RepoPath):
                return scriptParam.RepoPath;
            case nameof(ScriptParam.ScriptPath):
                return scriptParam.ScriptPath;
            case nameof(ScriptParam.CloneUrlStart):
                return scriptParam.CloneUrlStart;
            case nameof(ScriptParam.CloneUrlEnd):
                return scriptParam.CloneUrlEnd;
            case nameof(ScriptParam.CloneUrl):
                return scriptParam.CloneUrl;
        }
        throw new Exception($"{nameof(SelectProp)} problem");
    }
}