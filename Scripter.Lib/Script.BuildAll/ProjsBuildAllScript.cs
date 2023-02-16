namespace Scripter;

public class ProjsBuildAllScript 
    : BuildAllBase
{
    private readonly IProjectList projectList;

    public ProjsBuildAllScript(
        IProjectList projectList
        , BuildAllDTO buildAllDTO)
            : base(buildAllDTO)
    {
        this.projectList = projectList;
    }

    public override string[] GetScript()
    {
        Script = new List<string>();
        foreach (var project in projectList.Projects)
        {
            AddLine(project);
        }
        return Script.ToArray();
    }
}