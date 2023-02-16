using DIHelper.Unity;
using Unity;

namespace Scripter;

public class JoinableScriptSet
    : UnityDependencySet
{
    public JoinableScriptSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IScriptParam, ScriptParam>();

        RegisterScript<CloneScript>(JoinableScripts.Clone);
        RegisterScript<PullScript>(JoinableScripts.Pull);
        RegisterScript<TestScript>(JoinableScripts.Test);
        RegisterScript<CompileScript>(JoinableScripts.Compile);
        RegisterScript<VersionScript>(JoinableScripts.VersionFile);
        RegisterScript<CopyBuildScript>(JoinableScripts.CopyBuild);
        RegisterScript<CopyBuildWpfScript>(JoinableScripts.CopyBuildWpf);
        RegisterScript<CopyAppScript>(JoinableScripts.CopyApp);
        RegisterScript<BuildScript>(JoinableScripts.Build);
        RegisterScript<AppBuildScript>(JoinableScripts.BuildApp);

        //Cpp
        RegisterScript<CppCompileScript>(JoinableScripts.CompileCpp);
        RegisterScript<CppCopyBuildScript>(JoinableScripts.CopyBuildCpp);
    }

    private void RegisterScript<TData>(JoinableScripts script)
        where TData : IScript
    {
        Container
            .RegisterSingleton<IScript, TData>(
                script.ToString());
    }
}