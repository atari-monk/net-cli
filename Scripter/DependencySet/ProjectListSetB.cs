using DIHelper.Unity;
using Scripter.Data.Helper;
using Unity;
using Unity.Injection;

namespace Scripter;

public class ProjectListSetB
    : UnityDependencySet
{
    public ProjectListSetB(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterAllProjList();
        RegisterAllAppsList();
    }

    private void RegisterAllProjList()
    {
        Container.RegisterSingleton<IProjectList, AllProjList>(
            nameof(AllProjList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(ResetingProjExtractor))
                , Container.Resolve<IDictionary<string, ICodeData>>()));
    }

    private void RegisterAllAppsList()
    {
        Container.RegisterSingleton<IProjectList, AllAppsList>(
            nameof(AllAppsList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(SumingProjExtractor))
                , Container.Resolve<IDictionary<string, ICodeData>>()));
    }
}