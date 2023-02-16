using Scripter.Data.Helper;

namespace Scripter;

public interface IProjectExtractor
{
    List<ProjectDTO> Projects { get; }

    void ExtractProjects(params ICodeData[] codeData);
    void ExtractProjects(ProjectDTO project);
}