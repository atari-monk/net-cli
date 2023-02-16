using Xunit;

namespace Scripter.Lib.Tests;

public class CompileScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, $"Set-Location -Path \"C:\\atari-monk\\Code\\cli-helper\"")]
    [InlineData(1, $"dotnet build")]
    [InlineData(2, $"dotnet build --configuration Release")]
    [InlineData(3, $"dotnet publish -c Release")]
    [InlineData(4, $"Set-Location -Path \"C:\\atari-monk\\Build.Script\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new CompileScript(GetParams());

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}