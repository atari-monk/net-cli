using Scripter.Data.Helper;

namespace Scripter.Data;

public class CommandDotNetLibData 
    : ManyRefLibData
{
    private const string Repo = "commanddotnet-helper";
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CommandDotNetMDIHelper;
    protected ProjectDTO? CommandDotNetIoCUnity;
    protected ProjectDTO? CommandDotNetUnityHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        CommandDotNetHelper = SetProjectDepsAndTests(
            Repo
            , "CommandDotNet.Helper"
            , SetTests("CommandDotNet.Helpers.Tests")
            , DIHelper
            , ConfigWrapper);
        CommandDotNetMDIHelper = Set(
            Repo
            , "CommandDotNet.MDI.Helper"
            , DIHelper
            , ConfigWrapper);
        CommandDotNetIoCUnity = Set(
            Repo
            , project: "CommandDotNet.IoC.Unity");
        ArgumentNullException.ThrowIfNull(CLIHelper);
        CommandDotNetUnityHelper = Set(
            Repo
            , "CommandDotNet.Unity.Helper"
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            );
    }
}