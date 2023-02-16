using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class ModernDiyBoxTests 
    : ScriptTest
{
    private static ICodeData codeData
        = new DiyBoxData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\DiyBox.CommandDotNet.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\DiyBox.Modern.CliApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "DiyBox.Modern.CliApp.BuildAll.ps1"
                , "DiyBox.Modern.CliApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}