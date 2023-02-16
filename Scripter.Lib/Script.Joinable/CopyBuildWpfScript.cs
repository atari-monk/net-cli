namespace Scripter;

public class CopyBuildWpfScript
    : CopyBuildScript
{
    public CopyBuildWpfScript(
        IScriptParam scriptParam) 
            : base(scriptParam)
    {
    }

    protected override string GetNetVer() => "net6.0-windows";
}