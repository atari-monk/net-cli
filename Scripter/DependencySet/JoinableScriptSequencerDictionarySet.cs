using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class JoinableScriptSequencerDictionarySet 
	: UnityDependencySet
{
	public JoinableScriptSequencerDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<ProjectTypes, IJoinableScriptSequencer>>(
			c => FillDictionary(
                new Dictionary<ProjectTypes, IJoinableScriptSequencer>()));
	}

    private IDictionary<ProjectTypes, IJoinableScriptSequencer> FillDictionary(
        IDictionary<ProjectTypes, IJoinableScriptSequencer> store)
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
        IDictionary<ProjectTypes, IJoinableScriptSequencer> store
		, ProjectTypes sequencer)
	{
        store.Add(sequencer, ResolveSequencer(sequencer));
	}

    private IJoinableScriptSequencer ResolveSequencer(ProjectTypes sequencer)
	{
		return Container.Resolve<IJoinableScriptSequencer>(
			sequencer.ToString());
	}
}