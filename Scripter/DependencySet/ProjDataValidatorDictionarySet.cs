using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class ProjDataValidatorDictionarySet 
	: UnityDependencySet
{
	public ProjDataValidatorDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<ProjectTypes, IProjDataValidator>>(
			c => FillDictionary(
                new Dictionary<ProjectTypes, IProjDataValidator>()));
	}

    private IDictionary<ProjectTypes, IProjDataValidator> FillDictionary(
        IDictionary<ProjectTypes, IProjDataValidator> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, ProjectTypes.Default);
		Add(store, ProjectTypes.App);
		Add(store, ProjectTypes.Wpf);
		Add(store, ProjectTypes.WpfApp);

        //Cpp
		Add(store, ProjectTypes.CppApp);
		return store;
    }

	private void Add(
        IDictionary<ProjectTypes, IProjDataValidator> store
		, ProjectTypes validator)
	{
        store.Add(validator, ResolveScript(validator));
	}

    private IProjDataValidator ResolveScript(ProjectTypes validator)
	{
		return Container.Resolve<IProjDataValidator>(
			validator.ToString());
	}
}