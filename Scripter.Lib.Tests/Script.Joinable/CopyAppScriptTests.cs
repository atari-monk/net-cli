using Xunit;

namespace Scripter.Lib.Tests;

public class CopyAppScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, "$projBuildPath = \"C:\\atari-monk\\Build\\cli-helper\\CLIHelper\"")]
    [InlineData(1, "$appsPath = \"C:\\atari-monk\\Apps\"")]
    [InlineData(2, "$projBuildPathAll = \"C:\\atari-monk\\Build\\cli-helper\\CLIHelper\\*\"")]
    [InlineData(3, "$appPath = \"C:\\atari-monk\\Apps\\CLIHelper\"")]
    [InlineData(4, "$versionFilePath = \"C:\\atari-monk\\Build\\Version.csv\"")]
    [InlineData(5, "Copy-Item -Path $projBuildPath -Destination $appsPath -Force")]
    [InlineData(6, "Copy-Item -Path $projBuildPathAll -Destination $appPath -Recurse -Force")]
    [InlineData(7, "Copy-Item -Path $versionFilePath -Destination $appsPath -Force")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new CopyAppScript(GetParams());

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}