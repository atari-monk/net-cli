using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Inventory;

public class ModernInventoryTests 
    : ScriptTest
{
    private static ICodeData codeData
        = new ModernInventoryAppData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\Inventory.Table.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "ModernInventory.BuildAll.ps1"
                , "Inventory.Modern.ConsoleApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}