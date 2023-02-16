using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests 
    : ScriptTest
{
    [Theory]
    [MemberData(nameof(CopyScriptData.Data), MemberType= typeof(CopyScriptData))]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new CopyBuildScript(GetParams());

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}