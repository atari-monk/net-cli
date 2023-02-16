using Scripter.Data.Helper;

namespace Scripter.Lib;

public class DefaultProjValidator
    : ProjDataValidatorBase
{
    public override bool Validate(ProjectDTO project)
    {
        return project.IsApp == false
            && project.IsWpf == false
            && project.IsCsharp == true;
    }
}