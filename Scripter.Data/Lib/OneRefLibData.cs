using Scripter.Data.Helper;

namespace Scripter.Data;

public class OneRefLibData 
    : IndependantLibData
{
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? ConfigWrapper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? ModelHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIHelper = SetProjectDepsAndTests(
            "cli-helper"
            , "CLIHelper"
            , SetTests("CLIHelper.Tests")
            , DIHelper);
        ConfigWrapper = SetProjectDepsAndTests(
            "config-wrapper"
            , "Config.Wrapper"
            , SetTests("Config.Wrapper.Tests")
            , DIHelper);
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCore.Helper");
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper"
            , DIHelper);
    }
}