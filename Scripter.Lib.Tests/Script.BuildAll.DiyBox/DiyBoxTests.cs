using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class DiyBoxTests 
    : ScriptTest
{
    private static ICodeData codeData
        = new DiyBoxData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "DiyBox.BuildAll.ps1"
                , "DiyBox.ConsoleApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}