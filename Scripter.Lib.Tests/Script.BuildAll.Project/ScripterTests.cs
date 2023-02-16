using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class ScripterTests 
    : ScriptTest
{
    private static ICodeData codeData
        = new ScripterData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "Scripter.BuildAll.ps1"
                , "Scripter"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}