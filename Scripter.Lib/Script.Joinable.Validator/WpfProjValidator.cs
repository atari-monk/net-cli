using Scripter.Data.Helper;

namespace Scripter.Lib;

public class WpfProjValidator
    : ProjDataValidatorBase
{
    public override bool Validate(ProjectDTO project)
    {
        return project.IsApp == false
            && project.IsWpf == true
            && project.IsCsharp == true;
    }
}