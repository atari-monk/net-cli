using Scripter.Data.Helper;

namespace Scripter;

public class ProjBuildAllScript 
    : BuildAllBase
        , IProjBuildAll
{
    private readonly IProjectExtractor projectExtractor;
    private readonly ICodeData codeData;
    private readonly ProjBuildAllDTO scriptDTO;

    public ProjBuildAllDTO Data => scriptDTO;

    public ProjBuildAllScript(
        IProjectExtractor projectExtractor
        , ICodeData codeData
        , ProjBuildAllDTO scriptDTO)
            : base(scriptDTO)
    {
        this.projectExtractor = projectExtractor;
        this.codeData = codeData;
        this.scriptDTO = scriptDTO;
    }

    public override string[] GetScript()
    {
        Script.Clear();
        var app = codeData[scriptDTO.Project];
        if (app == null) 
            throw new ArgumentException($"{app} not found");
        projectExtractor.ExtractProjects(app);
        foreach (var project in projectExtractor.Projects)
        {
            AddLine(project);    
        }
        return Script.ToArray();
    }
}