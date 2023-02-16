using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class ScriptWriterDictionarySet 
	: UnityDependencySet
{
	public ScriptWriterDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<ScriptWriters, IScriptWriter>>(
			c => FillDictionary(
                new Dictionary<ScriptWriters, IScriptWriter>()));
	}

    private IDictionary<ScriptWriters, IScriptWriter> FillDictionary(
        IDictionary<ScriptWriters, IScriptWriter> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, ScriptWriters.JoinableScript);
		Add(store, ScriptWriters.ProjectBuildAll);
		Add(store, ScriptWriters.BuildAll);
		return store;
    }

	private void Add(
        IDictionary<ScriptWriters, IScriptWriter> store
		, ScriptWriters writer)
	{
        store.Add(writer, ResolveWriter(writer));
	}

    private IScriptWriter ResolveWriter(ScriptWriters writer)
	{
		return Container.Resolve<IScriptWriter>(
			writer.ToString());
	}
}