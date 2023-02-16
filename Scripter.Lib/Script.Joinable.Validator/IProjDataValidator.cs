using Scripter.Data.Helper;

namespace Scripter.Lib;

public interface IProjDataValidator
{
    bool Validate(ProjectDTO project);
}