using Scripter.Data.Helper;

namespace Scripter.Data;

public abstract class InventoryLibData
    : AllLibsData
{
    protected ProjectDTO? DataLib;
    protected ProjectDTO? TableLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        DataLib = Set(
            "inventory-data"
            , "Inventory.Data"
            , EFCoreHelper
            , DIHelper
            , ModelHelper
            , ConfigWrapper
        );
        ArgumentNullException.ThrowIfNull(DataToTable);
        TableLib = Set(
            "inventory-table"
            , "Inventory.Table"
            , DIHelper
            , ModelHelper
            , DataToTable
            , DataLib
        );
    }
}