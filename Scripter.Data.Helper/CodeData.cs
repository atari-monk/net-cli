namespace Scripter.Data.Helper;

public abstract class CodeData 
    : Dictionary<string,ProjectDTO>
        , ICodeData
{
    public CodeData()
    {
        SetAllData();
    }

    protected abstract void SetAllData();
    
    protected ProjectDTO SetTest(
        string project)
    {
        return new ProjectDTO(
            RepoFolder: string.Empty
            , ProjFolder: project
            , Dependencies : new List<ProjectDTO>()
            , IsApp: false
            , IsWpf: false);
    }

    protected ProjectDTO[] SetTests(
        params string[] projects)
    {
        var list = new List<ProjectDTO>();
        foreach (var proj in projects)
        {
            list.Add(SetTest(proj));
        }
        return list.ToArray();
    }
    
    protected ProjectDTO Set(ProjectDTO data)
    {
        Add(data.ProjFolder, data);
        return data;
    }

    protected ProjectDTO Set(
        string repo
        , string project)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies : new List<ProjectDTO>()
            , IsApp: false
            , IsWpf: false);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO SetProjAndTests(
        string repo
        , string project
        , params ProjectDTO[] tests)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies : new List<ProjectDTO>()
            , IsApp: false
            , IsWpf: false
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO SetProjAndTests(
        string repo
        , string project
        , bool isApp
        , params ProjectDTO[] tests)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies : new List<ProjectDTO>()
            , IsApp: isApp
            , IsWpf: false
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: false
            , IsWpf: false);
        Add(proj.ProjFolder, proj);
        return proj;
    }
    
    protected ProjectDTO SetProjectDepsAndTests(
        string repo
        , string project
        , ProjectDTO[] tests
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: false
            , IsWpf: false
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO SetProjectDepsAndTests(
        string repo
        , string project
        , bool isApp
        , ProjectDTO[] tests
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: false
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO SetProjectDepsAndTests(
        string repo
        , string project
        , bool isApp
        , bool isWpf
        , ProjectDTO[] tests
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: isWpf
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , ProjectDTO[] tests
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: false
            , IsWpf: false
            , Tests : new List<ProjectDTO>(tests));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , bool isApp = false
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: false);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , bool isApp = false
        , bool isWpf = false
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: isWpf);
        Add(proj.ProjFolder, proj);
        return proj;
    }
}