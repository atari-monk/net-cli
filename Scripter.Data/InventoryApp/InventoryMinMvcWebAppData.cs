using Scripter.Data.Helper;

namespace Scripter.Data;

public class InventoryMinMvcWebAppData 
    : CodeData
{
    protected override void SetAllData()
    {
        Set(
            "inventory-min-mvc-web-app"
            , "Inventory.Min.Mvc.Web.App"
            , isApp: true);
    }
}