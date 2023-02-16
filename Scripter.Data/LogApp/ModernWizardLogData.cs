using Scripter.Data.Helper;

namespace Scripter.Data;

public class ModernWizardLogData 
    : LogLibData
{
    private ProjectDTO? modernWizardCLIApp;

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
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(InputWizards);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernWizardCLIApp = Set(
            "log-modern-wizard-consoleapp"
            , "Log.Modern.Wizard.ConsoleApp"
            , isApp: true
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , CLIReader
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , CLIWizardHelper
            , Data
            , Tables
            , InputWizards
            );
    }
}