using Scripter.Data.Helper;

namespace Scripter.Data;

public class InventoryMinData 
    : AllLibsData
{
    protected ProjectDTO? DataLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        DataLib = Set(
            "inventory-min-data"
            , "Inventory.Min.Data"
            , EFCoreHelper
            , DIHelper
            , ModelHelper
            , ConfigWrapper);
        var cliapp = Set(
            "inventory-min-data"
            , "Inventory.Min.Data.Seed.App"
            , isApp: true
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , DataLib);
    }
}