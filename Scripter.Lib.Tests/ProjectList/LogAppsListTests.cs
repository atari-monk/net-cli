using System.Collections.Generic;
using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class LogAppsListTests 
    : ProjListTestBase
{
    private static IProjectList projsLibsList
        = new LogAppsList(
            new SumingProjExtractor()
            , new List<ICodeData> 
            {
                new ModernLogData()
                , new ModernWizardLogData()
                , new ModernMDILogData()
                , new ConsoleLogData()
            });

    [Theory]
    [InlineData(0, "EFCore.Helper")]
    [InlineData(1, "DIHelper")]
    [InlineData(2, "CLIHelper")]
    [InlineData(3, "Config.Wrapper")]
    [InlineData(4, "ModelHelper")]
    [InlineData(5, "DataToTable")]
    [InlineData(6, "CommandDotNet.Helper")]
    [InlineData(7, "CommandDotNet.IoC.Unity")]
    [InlineData(8, "CommandDotNet.Unity.Helper")]
    [InlineData(9, "Serilog.Wrapper")]
    [InlineData(10, "CRUDCommandHelper")]
    [InlineData(11, "Log.Data")]
    [InlineData(12, "Log.Table")]
    [InlineData(13, "DotNetExtension")]
    [InlineData(14, "Log.Modern.Lib")]
    [InlineData(15, "Log.Modern.ConsoleApp")]
    [InlineData(16, "CLIReader")]
    [InlineData(17, "CLIWizardHelper")]
    [InlineData(18, "Log.Wizard.Lib")]
    [InlineData(19, "Log.Modern.Wizard.ConsoleApp")]
    [InlineData(20, "CommandDotNet.MDI.Helper")]
    [InlineData(21, "Log.Modern.MDI.ConsoleApp")]
    [InlineData(22, "CLIFramework")]
    [InlineData(23, "Log.Console.Lib")]
    [InlineData(24, "Log.ConsoleApp")]
    public override void TestListContent(
        int index
        , string expected)
    {
        var acctual = GetItem(projsLibsList, index);

        Assert.Equal(expected, acctual);
    }
}