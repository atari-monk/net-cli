using Scripter.Data.Helper;

namespace Scripter.Lib;

public class CsharpAppProjValidator
    : ProjDataValidatorBase
{
    public override bool Validate(ProjectDTO project)
    {
        return project.IsApp == true
            && project.IsWpf == false
            && project.IsCsharp == true;
    }
}