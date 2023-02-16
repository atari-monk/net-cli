namespace Scripter;

public class BuildAllScript 
    : BuildAllBase
{
    private readonly IProjectList projectList;

    public BuildAllScript(
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