using Scripter.Data.Helper;

namespace Scripter;

public class LogAppsList
    : IProjectList
{
    private readonly IProjectExtractor projExtractor;
    private readonly List<ICodeData> codeData;

    public List<ProjectDTO> Projects => 
        projExtractor.Projects;

    public LogAppsList(
        IProjectExtractor projExtractor
        , List<ICodeData> codeData)
    {
        this.projExtractor = projExtractor;
        this.codeData = codeData;
        ArgumentNullException.ThrowIfNull(this.projExtractor);
        ArgumentNullException.ThrowIfNull(this.codeData);
        Create();
    }

    private void Create()
    {
        projExtractor.ExtractProjects(
            codeData[0]["Log.Modern.ConsoleApp"]);
        projExtractor.ExtractProjects(
            codeData[1]["Log.Modern.Wizard.ConsoleApp"]);
        projExtractor.ExtractProjects(
            codeData[2]["Log.Modern.MDI.ConsoleApp"]);
        projExtractor.ExtractProjects(
            codeData[3]["Log.ConsoleApp"]);
    }
}