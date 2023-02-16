using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamTests : ScriptParamTestBase
{
    [Theory]
    [InlineData(nameof(ScriptParam.Project.RepoFolder), "cli-helper")]
    [InlineData(nameof(ScriptParam.Project.ProjFolder), "CLIHelper")]
    [InlineData(nameof(ScriptParam.XmlVersionFile), "Version.xml")]
    [InlineData(nameof(ScriptParam.CodePath), @"C:\atari-monk\Code")]
    [InlineData(nameof(ScriptParam.BuildPath), @"C:\atari-monk\Build")]
    [InlineData(nameof(ScriptParam.RepoPath), @"C:\atari-monk\Code\cli-helper")]
    [InlineData(nameof(ScriptParam.ScriptPath), @"C:\atari-monk\Build.Script")]
    [InlineData(nameof(ScriptParam.CloneUrlStart), @"https://github.com/atari-monk/")]
    [InlineData(nameof(ScriptParam.CloneUrlEnd), ".git")]
    [InlineData(nameof(ScriptParam.CloneUrl), @"https://github.com/atari-monk/cli-helper.git")]
    public override void TestParams(
        string propName
        , string expected)
    {
        var sut = GetSut();

        var acctual = SelectProp(sut, propName);

        Assert.Equal(expected, acctual);
    }    
}