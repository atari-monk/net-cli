using Scripter.Data;
using Unity;

namespace Scripter;

public class InventoryBuildAllSet 
    : ProjBuildAllSetBase
{
    public InventoryBuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterProjBuildAll<MyCliLibInventoryAppData>(
            "ConsoleLibInventory.BuildAll.ps1"
            , "Inventory.ConsoleLib.ConsoleApp");
        RegisterProjBuildAll<ModernInventoryAppData>(
            "ModernInventory.BuildAll.ps1"
            , "Inventory.Modern.ConsoleApp");
    }
}