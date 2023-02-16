using Scripter.Data.Helper;

namespace Scripter.Lib.Tests;

public abstract class ScriptTest
{
    public abstract void TestScriptContent(
        int index
        , string expected);

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }

    protected static ScriptParam GetParams(
        bool isApp = false
        , bool isWpf = false)
    {
        return new ScriptParam()
        {
            Project = new ProjectDTO(
                RepoFolder: "cli-helper"
                , ProjFolder: "CLIHelper"
                , IsApp: isApp
                , IsWpf: isWpf
            )
        };
    } 
}