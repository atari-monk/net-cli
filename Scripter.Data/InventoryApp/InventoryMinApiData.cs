namespace Scripter.Data;

public class InventoryMinApiData 
    : InventoryMinCliAppData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataLib);
        var api = SetProjectDepsAndTests(
            "inventory-min-api"
            , "Inventory.Min.Api"
            , isApp: true
            , SetTests(
                "Inventory.Min.Api.Tests")
            , EFCoreHelper
            , ModelHelper
            , DataLib
            );
    }
}