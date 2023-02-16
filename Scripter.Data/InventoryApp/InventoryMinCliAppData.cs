namespace Scripter.Data;

public class InventoryMinCliAppData 
    : InventoryMinData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(DataLib);
        var logicLib = Set(
            "inventory-min-lib"
            , "Inventory.Min.Lib"
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , DataLib);
        var tableLib = Set(
            "inventory-min-table"
            , "Inventory.Min.Table"
            , DIHelper
            , ModelHelper
            , DataToTable
            , DataLib);
        var cliapp = SetProjectDepsAndTests(
            "inventory-min-cli-app"
            , "Inventory.Min.Cli.App"
            , isApp: true
            , SetTests(
                "Inventory.Min.Cli.App.TestApi"
                , "Inventory.Min.Cli.App.Tests")
            , EFCoreHelper
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , DataLib
            , tableLib
            , logicLib);
    }
}