namespace Scripter.Lib;

public class ProjectBuildAllScriptWriter
    : ScriptWriter
{
    private readonly IScriptParam? scriptParam;
    private readonly List<IProjBuildAll>? projBuildAllScripts;

    public ProjectBuildAllScriptWriter(
        IScriptParam scriptParam
        , List<IProjBuildAll> projBuildAllScripts
        )
    {
        this.scriptParam = scriptParam;
        this.projBuildAllScripts = projBuildAllScripts;
    }

    public override void WriteScripts()
    {
        ArgumentNullException.ThrowIfNull(projBuildAllScripts);
        foreach (var script in projBuildAllScripts)
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