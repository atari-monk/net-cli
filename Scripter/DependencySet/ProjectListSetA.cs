using DIHelper.Unity;
using Scripter.Data;
using Scripter.Data.Helper;
using Unity;
using Unity.Injection;

namespace Scripter;

public class ProjectListSetA 
    : UnityDependencySet
{
    public ProjectListSetA(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterProjExtractor();
        RegisterLibsList();
        RegisterLogAppsData();
        RegisterLogAppsList();
    }

    private void RegisterProjExtractor()
    {
        Container
            .RegisterType<IProjectExtractor, ResetingProjExtractor>(
                nameof(ResetingProjExtractor))
            .RegisterType<IProjectExtractor, SumingProjExtractor>(
                nameof(SumingProjExtractor));
    }

    private void RegisterLibsList()
    {
        Container.RegisterSingleton<IProjectList, LibsList>(
            nameof(LibsList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(ResetingProjExtractor))
                , Container.Resolve<ICodeData>(
                    nameof(AllLibsData))));
    }

    private void RegisterLogAppsData()
    {
        Container.RegisterFactory<List<ICodeData>>(
            "LogAppsFactory"
            , (c) =>
            new List<ICodeData>
            {
                c.Resolve<ICodeData>(nameof(ModernLogData))
                , c.Resolve<ICodeData>(nameof(ModernWizardLogData))
                , c.Resolve<ICodeData>(nameof(ModernMDILogData))
                , c.Resolve<ICodeData>(nameof(ConsoleLogData))
            });
    }

    private void RegisterLogAppsList()
    {
        Container.RegisterSingleton<IProjectList, LogAppsList>(
            nameof(LogAppsList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(SumingProjExtractor))
                , Container.Resolve<List<ICodeData>>(
                    "LogAppsFactory")));
    }
}