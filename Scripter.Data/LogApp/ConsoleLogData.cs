using Scripter.Data.Helper;

namespace Scripter.Data;

public class ConsoleLogData 
    : LogLibData
{
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(InputWizards);
        ArgumentNullException.ThrowIfNull(ConsoleLibCmds);
        consoleLibCLIApp = Set(
            "log-console-lib-console-app"
            , "Log.ConsoleApp"
            , isApp: true
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , CLIReader
            , DataToTable
            , SerilogWrapper
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , Data
            , Tables
            , InputWizards
            , ConsoleLibCmds
            );
    }
}