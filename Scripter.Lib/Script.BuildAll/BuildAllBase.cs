using Scripter.Data.Helper;

namespace Scripter;

public abstract class BuildAllBase 
    : IBuildAll
{
    protected List<string> Script;
    protected readonly BuildAllDTO? BuildAllDTO;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(BuildAllDTO);
            return BuildAllDTO.File;
        }
    }

    public BuildAllBase(
        BuildAllDTO buildAllDTO)
    {
        BuildAllDTO = buildAllDTO;
        ArgumentNullException.ThrowIfNull(BuildAllDTO);
        Script = new List<string>();
    }

    public abstract string[] GetScript();

    private bool IsNotInScript(ProjectDTO project)
    {
        foreach (var line in Script)
        {
            if (line == GetScriptLine(project)) return false;
        }
        return true;
    }

    private static string GetScriptLine(ProjectDTO project)
    {
        return $"& \"$PSScriptRoot\\{project.ProjFolder}.Build.ps1\"";
    }

    protected void AddLine(ProjectDTO project)
    {
        if(IsNotInScript(project))
            Script.Add(GetScriptLine(project));
    }
}