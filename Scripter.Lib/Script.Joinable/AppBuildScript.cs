namespace Scripter;

public class AppBuildScript
    : BuildScript
{
    public AppBuildScript(IScriptParam scriptParam)
        : base(scriptParam)
    {
    }

    protected override string[] GetScriptContent()
    {
        return new string[]
        {
            $"& \"$PSScriptRoot\\{ProjName}.Clone.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Pull.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Test.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Copy.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.CopyApp.ps1\""
        };
    }
}