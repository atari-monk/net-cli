using Xunit;

namespace Scripter.Lib.Tests;

public class WpfProjCopyScriptTests 
    : ScriptTest
{
    [Theory]
    [MemberData(nameof(WpfProjCopyScriptData.Data), MemberType= typeof(WpfProjCopyScriptData))]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new CopyBuildWpfScript(GetParams(isWpf: true));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}