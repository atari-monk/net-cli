using Scripter.Data.Helper;

namespace Scripter.Data;

public class ModernInventoryLibData 
    : InventoryLibData
{
    protected ProjectDTO? ModernLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(DataLib);
        ModernLib = Set(
            "inventory-modern-lib"
            , "Inventory.Modern.Lib"
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , DataLib
            );
    }
}