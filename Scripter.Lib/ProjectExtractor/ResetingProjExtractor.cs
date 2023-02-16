using Scripter.Data.Helper;

namespace Scripter;

public class ResetingProjExtractor 
    : ProjectExtractorBase
{
    public override void ExtractProjects(
        params ICodeData[] codeData)
    {
        Clear();
        base.ExtractProjects(codeData);
    }

    public override void ExtractProjects(
        ProjectDTO project)
    {
        Clear();
        base.ExtractProjects(project);
    }
}