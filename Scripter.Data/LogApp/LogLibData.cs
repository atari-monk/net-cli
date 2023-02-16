using Scripter.Data.Helper;

namespace Scripter.Data;

public abstract class LogLibData 
    : AllLibsData
{
    protected ProjectDTO? Data;
    protected ProjectDTO? Tables;
    protected ProjectDTO? ConsoleLibCmds;
    protected ProjectDTO? InputWizards;
    protected ProjectDTO? ModernLibCmds;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        Data = Set(
            "log-data"
            , "Log.Data"
            , EFCoreHelper
            , ModelHelper
            );
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        Tables = Set(
            "log-table"
            , "Log.Table"
            , DIHelper
            , ModelHelper
            , DataToTable
            , Data
            );
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ConsoleLibCmds = Set(
            "log-console-lib"
            , "Log.Console.Lib"
            , EFCoreHelper
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , Data
            );
        ArgumentNullException.ThrowIfNull(CLIReader);
        InputWizards = Set(
            "log-wizard-lib"
            , "Log.Wizard.Lib"
            , EFCoreHelper
            , CLIReader
            , CLIWizardHelper
            , Data
            );
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ModernLibCmds = SetProjectDepsAndTests(
            "log-modern-lib"
            , "Log.Modern.Lib"
            , SetTests("Log.Modern.Lib.Tests")
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , Data
            );
    }   
}