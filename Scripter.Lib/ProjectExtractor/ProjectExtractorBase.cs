using Scripter.Data.Helper;

namespace Scripter;

public abstract class ProjectExtractorBase
    : IProjectExtractor
{
    private List<ProjectDTO> projects;

    public List<ProjectDTO> Projects => projects;

    protected ProjectExtractorBase()
    {
        this.projects = new List<ProjectDTO>();
    }

    public virtual void ExtractProjects(params ICodeData[] codeData)
    {
        foreach (var data in codeData)
        {
            foreach (var proj in data.Values)
            {
                SelectProjects(proj);
            }
        }
    }

    public virtual void ExtractProjects(ProjectDTO project)
    {
        SelectProjects(project);
    }

    protected void Clear()
    {
        projects.Clear();
    }

    protected void SelectProjects(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                if (library == null)
                    throw new NullReferenceException($"{library} is null");
                SelectProjects(library);
            }
        }
        if (IsNotYet(project))
            projects.Add(project);
    }

    private bool IsNotYet(ProjectDTO project)
    {
        return projects.Any(p => p.ProjFolder == project.ProjFolder) == false;
    }
}