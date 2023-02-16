namespace Scripter.Data.Helper;

public record ProjectDTO(
    string RepoFolder
    , string ProjFolder
    , List<ProjectDTO>? Dependencies = default
    , bool IsApp = false
    , bool IsWpf = false
    , bool IsCsharp = true
    , bool IsCpp = false
    , List<ProjectDTO>? Tests = default);