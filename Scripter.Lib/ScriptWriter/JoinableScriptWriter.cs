using Scripter.Data.Helper;

namespace Scripter.Lib;

public class JoinableScriptWriter
    : ScriptWriter
{
    private readonly IProjectList? projList;
    private readonly IScriptParam? scriptParam;
    private readonly IDictionary<ProjectTypes, IProjDataValidator> validators;
    private readonly IDictionary<ProjectTypes, IJoinableScriptSequencer> sequencers;
    private readonly IDictionary<JoinableScripts, IScript>? scripts;

    public JoinableScriptWriter(
        IProjectList projList
        , IScriptParam scriptParam
        , IDictionary<ProjectTypes, IProjDataValidator> validators
        , IDictionary<ProjectTypes, IJoinableScriptSequencer> sequencers
        , IDictionary<JoinableScripts, IScript> scripts
        )
    {
        this.projList = projList;
        this.scriptParam = scriptParam;
        this.validators = validators;
        this.sequencers = sequencers;
        this.scripts = scripts;

        ArgumentNullException.ThrowIfNull(this.projList);
    }

    public override void WriteScripts()
    {
        var projects = projList?.Projects;
        ArgumentNullException.ThrowIfNull(projects);
        ArgumentNullException.ThrowIfNull(scripts);
        foreach (var project in projects)
        {
            SetProject(project);
            foreach (var validator in validators)
            {
                if(validator.Value.Validate(project))
                {
                    var scriptSequence = sequencers[validator.Key].GetProjScriptSequence();
                    foreach (var scriptKey in scriptSequence)
                    {
                        WriteScript(scripts[scriptKey]);
                    }
                }
            }
        }
    }

    private void SetProject(ProjectDTO project)
    {
        ArgumentNullException.ThrowIfNull(scriptParam);
        scriptParam.Project = project;
    }

    private void WriteScript(IScript script)
    {
        ArgumentNullException.ThrowIfNull(scriptParam);
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , script.File)
            , script.GetScript());
    }
}