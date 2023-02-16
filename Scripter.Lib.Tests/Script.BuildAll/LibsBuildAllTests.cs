using Xunit;

namespace Scripter.Lib.Tests;

public class LibsBuildAllTests 
    : ScriptTest
        , IClassFixture<LibsListFixture>
{
    private readonly LibsListFixture fixture;

    public LibsBuildAllTests(LibsListFixture fixture)
    {
        this.fixture = fixture;
    }

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\Vector.Lib.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\Xml.Generator.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\WpfHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\UnityContainer.Tests.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Pattern.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Net.Examples.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\XUnit.Helper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(18, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(19, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(20, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(21, $"& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(22, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(23, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(
            fixture.CodeData
            , new BuildAllDTO("LibBuildAll.ps1"));
   
        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}