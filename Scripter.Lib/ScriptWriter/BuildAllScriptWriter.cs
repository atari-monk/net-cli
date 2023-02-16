namespace Scripter.Lib;

public class BuildAllScriptWriter
    : ScriptWriter
{
    private readonly IScriptParam? scriptParam;
    private readonly List<IBuildAll> buildAllScripts;

    public BuildAllScriptWriter(
        IScriptParam scriptParam
        , List<IBuildAll> buildAllScripts
        )
    {
        this.scriptParam = scriptParam;
        this.buildAllScripts = buildAllScripts;
    }

    public override void WriteScripts()
    {
        ArgumentNullException.ThrowIfNull(buildAllScripts);
        foreach (var script in buildAllScripts)
        {
            WriteScript(script);   
        }
    }

    private void WriteScript(IBuildAll buildScript)
    {
        ArgumentNullException.ThrowIfNull(scriptParam);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , buildScript.File)
            , buildScript.GetScript());
    }
}