using Scripter.Data.Helper;

namespace Scripter.Data;

public class ManyRefLibData 
    : TwoRefLibData
{
    protected ProjectDTO? SerilogWrapper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DataToTable);
        SerilogWrapper = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper"
            , DIHelper
            , CLIHelper
            , ConfigWrapper);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , EFCoreHelper
            , ModelHelper
            , CLIReader);
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , EFCoreHelper
            , CLIHelper
            , ModelHelper
            , DataToTable);
        CLIFramework = SetProjectDepsAndTests(
            "cli-framework"
            , "CLIFramework"
            , SetTests("CLIFramework.Tests")
            , DIHelper
            , CLIHelper
            , CRUDCommandHelper
            , CLIWizardHelper
            );
    }
}