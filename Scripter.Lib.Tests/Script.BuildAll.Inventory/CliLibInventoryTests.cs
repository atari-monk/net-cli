using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Inventory;

public class CliLibInventoryTests 
    : ScriptTest
{
    private static readonly ICodeData codeData
        = new MyCliLibInventoryAppData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\Inventory.Table.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ResetingProjExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "ConsoleLibInventory.BuildAll.ps1"
                , "Inventory.ConsoleLib.ConsoleApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}