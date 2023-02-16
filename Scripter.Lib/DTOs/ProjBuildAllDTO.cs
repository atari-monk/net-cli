namespace Scripter;

public record ProjBuildAllDTO(string File, string Project) 
    : BuildAllDTO(File);