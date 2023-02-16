using DIHelper.Unity;
using Unity;
using Unity.Injection;

namespace Scripter;

public class BuildAllSet 
    : UnityDependencySet
{
    public BuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterBuildAll();
        RegisterLibsBuildAll();
        RegisterLogAppsBuildAll();
    }

    private void RegisterBuildAll()
    {
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(
            "BuildAll"
            , new InjectionConstructor(
                Container.Resolve<IProjectList>(
                    nameof(AllAppsList))
                , new BuildAllDTO("BuildAll.ps1")));
    }

    private void RegisterLibsBuildAll()
    {
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(
            "LibBuildAll"
            , new InjectionConstructor(
                Container.Resolve<IProjectList>(
                    nameof(LibsList))
                , new BuildAllDTO("LibBuildAll.ps1")));
    }

    private void RegisterLogAppsBuildAll()
    {
        Container.RegisterSingleton<IBuildAll, ProjsBuildAllScript>(
            "LogAppsBuildAll"
            , new InjectionConstructor(
                Container.Resolve<IProjectList>(
                    nameof(LogAppsList))
                , new BuildAllDTO("Log.Apps.BuildAll.ps1")));
    }
}