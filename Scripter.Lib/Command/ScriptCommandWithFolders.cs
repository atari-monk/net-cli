using System.Windows.Input;
using Scripter.Data.Helper;

namespace Scripter.Lib;

public class ScriptCommandWithFolders : ICommand
{
    public event EventHandler? CanExecuteChanged;
    private readonly IProjectList projectList;
    private readonly List<ICodeData> codeData;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> projectScripts;
    private readonly List<IProjBuildAll> projBuildAllScripts;
    private readonly IBuildAll buildAllScript;

    public ScriptCommandWithFolders(
        IProjectList projectList
        , List<ICodeData> codeData
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        , List<IProjBuildAll> projBuildAllScripts
        , IBuildAll buildAllScript)
    {
        this.projectList = projectList;
        this.codeData = codeData;
        this.scriptParam = scriptParam;
        this.projectScripts = projectScripts;
        this.projBuildAllScripts = projBuildAllScripts;
        this.buildAllScript = buildAllScript;
    }

    public void Invalidate()
    {
        CanExecuteChanged?.BeginInvoke(this, new EventArgs(), null, null);
    }
    
    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteProjBuildAllScripts();
        WriteScript(buildAllScript);
    }

    private void WriteProjectScripts()
    {
        foreach (var project in projectList.Projects)
        {
            SetProject(project);
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            foreach (var script in projectScripts)
            {
                if (scriptParam.Project.IsApp == false
                    && script is CopyAppScript) continue;
                SetDir(Path.Combine(scriptParam.ScriptPath
                    , scriptParam.Project.ProjFolder));
                WriteScript(script);
            }
        }
    }

    private void SetProject(ProjectDTO project)
    {
        scriptParam.Project = new ProjectDTO(
            project.RepoFolder
            , project.ProjFolder
            , IsApp: project.IsApp);
    }

    private void WriteScript(IScript script)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , scriptParam.Project.ProjFolder
                , script.File)
            , script.GetScript());
    }

    private void WriteProjBuildAllScripts()
    {
        foreach (var script in projBuildAllScripts)
        {
            WriteScript(script);   
        }
    }

    private void WriteScript(IProjBuildAll buildScript)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        if(IsDir( Path.Combine(scriptParam.ScriptPath, buildScript.Data.Project)))
        {
            File.WriteAllLines(
                Path.Combine(scriptParam.ScriptPath
                    , buildScript.Data.Project
                    , buildScript.File)
            , buildScript.GetScript());
        }
        else
        {
            File.WriteAllLines(
                Path.Combine(scriptParam.ScriptPath
                    , buildScript.File)
            , buildScript.GetScript());
        }
    }

    private void WriteScript(IBuildAll buildScript)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , buildScript.File)
            , buildScript.GetScript());
    }

    private bool IsDir(string path)
    {
        return Directory.Exists(path);
    }

    private void SetDir(string path)
    {
        if(Directory.Exists(path)) return;
        Directory.CreateDirectory(path);
    }
}
