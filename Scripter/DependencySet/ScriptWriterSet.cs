using DIHelper.Unity;
using Scripter.Lib;
using Unity;
using Unity.Injection;

namespace Scripter;

public class ScriptWriterSet 
	: UnityDependencySet
{
	public ScriptWriterSet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		RegisterScriptWriter<JoinableScriptWriter>(
			ScriptWriters.JoinableScript
            , GetJoinableScriptWriterCtor());
        RegisterScriptWriter<ProjectBuildAllScriptWriter>(
			ScriptWriters.ProjectBuildAll);
        RegisterScriptWriter<BuildAllScriptWriter>(
			ScriptWriters.BuildAll);
	}

    private void RegisterScriptWriter<TWriter>(
		ScriptWriters writer)
		where TWriter : IScriptWriter
	{
		Container.RegisterSingleton<IScriptWriter, TWriter>(
			writer.ToString());
	}
	
	private void RegisterScriptWriter<TWriter>(
		ScriptWriters writer
		, InjectionConstructor injectionConstructor)
		where TWriter : IScriptWriter
	{
		Container.RegisterSingleton<IScriptWriter, TWriter>(
			writer.ToString()
			, injectionConstructor);
	}

    private InjectionConstructor GetJoinableScriptWriterCtor()
    {
        return new InjectionConstructor(
            Container.Resolve<IProjectList>(nameof(AllProjList))
            , Container.Resolve<IScriptParam>()
            , Container.Resolve<IDictionary<ProjectTypes, IProjDataValidator>>()
            , Container.Resolve<IDictionary<ProjectTypes, IJoinableScriptSequencer>>()
            , Container.Resolve<IDictionary<JoinableScripts, IScript>>()
        );
    }
}