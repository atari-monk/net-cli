using Scripter.Data.Helper;

namespace Scripter.Data;

public class MyCliLibInventoryLibData 
    : InventoryLibData
{
    protected ProjectDTO? ConsoleLib;
    protected ProjectDTO? WizardLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 26);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DataLib);
        ConsoleLib = Set(
            "inventory-console-lib"
            , "Inventory.Console.Lib"
            , EFCoreHelper
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , DataLib
            );
        ArgumentNullException.ThrowIfNull(CLIReader);
        WizardLib = Set(
            "inventory-wizard-lib"
            , "Inventory.Wizard.Lib"
            , EFCoreHelper
            , CLIHelper
            , CLIReader
            , CLIWizardHelper
            , DataLib);
    }
}