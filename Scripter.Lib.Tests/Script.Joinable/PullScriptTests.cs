using Xunit;

namespace Scripter.Lib.Tests;

public class PullScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, "$repoPath = \"C:\\atari-monk\\Code\\cli-helper\"")]
    [InlineData(1, "$scriptPath = \"C:\\atari-monk\\Build.Script\"")]
    [InlineData(2, "$proj = \"cli-helper\"")]
    [InlineData(3, "if(-not (Test-Path $repoPath))")]
    [InlineData(4, "{")]
    [InlineData(5, "    Write-Output \"No path: $repoPath\"")]
    [InlineData(6, "}")]
    [InlineData(7, "else")]
    [InlineData(8, "{")]
    [InlineData(9, "   Set-Location $repoPath")]
    [InlineData(10, "   $result = git pull")]
    [InlineData(11, "   Write-Output \"$proj - $result\"")]
    [InlineData(12, "}")]
    [InlineData(13, "Set-Location $scriptPath")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new PullScript(GetParams());

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}