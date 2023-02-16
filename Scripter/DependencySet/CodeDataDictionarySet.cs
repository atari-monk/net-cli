using DIHelper.Unity;
using Scripter.Data;
using Scripter.Data.Helper;
using Unity;

namespace Scripter;

public class CodeDataDictionarySet 
	: UnityDependencySet
{
	public CodeDataDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<string, ICodeData>>(
			c => FillDictionary(
                new Dictionary<string, ICodeData>()));
	}

    private IDictionary<string, ICodeData> FillDictionary(
        IDictionary<string, ICodeData> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, nameof(AllLibsData));
		Add(store, nameof(TestAppsData));
		Add(store, nameof(WrapperAppsData));
		Add(store, nameof(SampleAppsData));
		Add(store, nameof(TutorialAppsData));
		Add(store, nameof(SmallAppsData));
		Add(store, nameof(ScripterData));
		Add(store, nameof(CliAppTemplateData));
		Add(store, nameof(AppStarterData));
		Add(store, nameof(DiyBoxData));
		Add(store, nameof(GameData));
		Add(store, nameof(ModernLogData));
		Add(store, nameof(ModernMDILogData));
		Add(store, nameof(ModernWizardLogData));
		Add(store, nameof(ConsoleLogData));
		Add(store, nameof(ModernInventoryAppData));
		Add(store, nameof(MyCliLibInventoryAppData));
		Add(store, nameof(ShapeEngineData));
		Add(store, nameof(LogMinCliAppData));
		Add(store, nameof(InventoryMinData));
		Add(store, nameof(InventoryMinCliAppData));
		Add(store, nameof(InventoryMinApiData));
		Add(store, nameof(InventoryMinMvcWebAppData));

        //Cpp
        Add(store, nameof(CppKinematics));
		return store;
    }

	private void Add(
        IDictionary<string, ICodeData> store
		, string key)
	{
        store.Add(key, ResolveScript(key));
	}

    private ICodeData ResolveScript(string key)
	{
		return Container.Resolve<ICodeData>(
			key.ToString());
	}
}