using Scripter.Data.Helper;

namespace Scripter.Lib;

public class WpfAppProjValidator
    : ProjDataValidatorBase
{
    public override bool Validate(ProjectDTO project)
    {
        return project.IsApp == true
            && project.IsWpf == true
            && project.IsCsharp == true;
    }
}