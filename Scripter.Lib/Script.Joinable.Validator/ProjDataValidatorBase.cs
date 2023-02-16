using Scripter.Data.Helper;

namespace Scripter.Lib;

public abstract class ProjDataValidatorBase
    : IProjDataValidator
{
    public abstract bool Validate(ProjectDTO project);
}