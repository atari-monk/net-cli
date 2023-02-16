using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Log;

public class ModernMDILogTests 
    : ScriptTest
{
    private static ICodeData codeData
        = new ModernMDILogData();

    [Theory]
    [InlineData(0, "& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(1, "& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(2, "& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, "& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, "& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(5, "& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(6, "& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(7, "& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(8, "& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(9, "& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(10, "& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(11, "& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(12, "& \"$PSScriptRoot\\Log.Table.Build.ps1\"")]
    [InlineData(13, "& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(14, "& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "ModernMDILog.BuildAll.ps1"
                , "Log.Modern.MDI.ConsoleApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}