using Scripter.Data.Helper;

namespace Scripter.Lib;

public class CppAppProjValidator
    : ProjDataValidatorBase
{
    public override bool Validate(ProjectDTO project)
    {
        return project.IsCpp == true
            && project.IsApp == true;
    }
}