using Scripter.Data.Helper;

namespace Scripter.Data;

public class CppKinematics
    : CodeData
{
    protected ProjectDTO? app;

    protected override void SetAllData()
    {
        app = Set(new ProjectDTO(
            "cpp-kinematics"
            , "cpp-kinematics"
            , null
            , IsApp: true
            , IsWpf: false
            , IsCsharp: false
            , IsCpp: true
            , null));
    }
}