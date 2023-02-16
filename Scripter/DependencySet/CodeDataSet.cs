using DIHelper.Unity;
using Scripter.Data;
using Scripter.Data.Helper;
using Unity;

namespace Scripter;

public class CodeDataSet 
    : UnityDependencySet
{
    public CodeDataSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterCodeData<AllLibsData>();
        RegisterCodeData<TestAppsData>();
        RegisterCodeData<WrapperAppsData>();
        RegisterCodeData<SampleAppsData>();
        RegisterCodeData<TutorialAppsData>();
        RegisterCodeData<SmallAppsData>();
        RegisterCodeData<ScripterData>();
        RegisterCodeData<CliAppTemplateData>();
        RegisterCodeData<AppStarterData>();
        RegisterCodeData<DiyBoxData>();
        RegisterCodeData<GameData>();
        RegisterCodeData<ModernLogData>();
        RegisterCodeData<ModernMDILogData>();
        RegisterCodeData<ModernWizardLogData>();
        RegisterCodeData<ConsoleLogData>();
        RegisterCodeData<ModernInventoryAppData>();
        RegisterCodeData<MyCliLibInventoryAppData>();
        RegisterCodeData<ShapeEngineData>();
        RegisterCodeData<LogMinCliAppData>();
        RegisterCodeData<InventoryMinData>();
        RegisterCodeData<InventoryMinCliAppData>();
        RegisterCodeData<InventoryMinApiData>();
        RegisterCodeData<InventoryMinMvcWebAppData>();
        //Cpp
        RegisterCodeData<CppKinematics>();

        
    }
    
    private void RegisterCodeData<TData>()
        where TData : ICodeData
    {
        Container
            .RegisterSingleton<ICodeData, TData>(
                typeof(TData).Name);
    }
}