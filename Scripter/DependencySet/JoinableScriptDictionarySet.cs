using DIHelper.Unity;
using Unity;

namespace Scripter;

public class JoinableScriptDictionarySet 
	: UnityDependencySet
{
	public JoinableScriptDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<JoinableScripts, IScript>>(
			c => FillDictionary(
                new Dictionary<JoinableScripts, IScript>()));
	}

    private IDictionary<JoinableScripts, IScript> FillDictionary(
        IDictionary<JoinableScripts, IScript> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, JoinableScripts.Clone);
		Add(store, JoinableScripts.Pull);
		Add(store, JoinableScripts.Test);
		Add(store, JoinableScripts.Compile);
		Add(store, JoinableScripts.VersionFile);
		Add(store, JoinableScripts.CopyBuild);
		Add(store, JoinableScripts.CopyBuildWpf);
		Add(store, JoinableScripts.CopyApp);
		Add(store, JoinableScripts.Build);
		Add(store, JoinableScripts.BuildApp);

        //Cpp
		Add(store, JoinableScripts.CompileCpp);
		Add(store, JoinableScripts.CopyBuildCpp);
		return store;
    }

	private void Add(
        IDictionary<JoinableScripts, IScript> store
		, JoinableScripts script)
	{
        store.Add(script, ResolveScript(script));
	}

    private IScript ResolveScript(JoinableScripts script)
	{
		return Container.Resolve<IScript>(
			script.ToString());
	}
}