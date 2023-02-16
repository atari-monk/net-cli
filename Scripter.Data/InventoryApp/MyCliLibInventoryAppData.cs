using Scripter.Data.Helper;

namespace Scripter.Data;

public class MyCliLibInventoryAppData
    : MyCliLibInventoryLibData
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
        ArgumentNullException.ThrowIfNull(DataLib);
        ArgumentNullException.ThrowIfNull(TableLib);
        ArgumentNullException.ThrowIfNull(WizardLib);
        ArgumentNullException.ThrowIfNull(ConsoleLib);
        consoleLibCLIApp = Set(
            "inventory-consolelib-consoleapp"
            , "Inventory.ConsoleLib.ConsoleApp"
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
            , DataLib
            , TableLib
            , WizardLib
            , ConsoleLib);
    }
}