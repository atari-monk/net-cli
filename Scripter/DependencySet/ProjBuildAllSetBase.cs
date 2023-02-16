using DIHelper.Unity;
using Scripter.Data.Helper;
using Unity;
using Unity.Injection;

namespace Scripter;

public abstract class ProjBuildAllSetBase 
    : UnityDependencySet
{
    public ProjBuildAllSetBase(
        IUnityContainer container) 
        : base(container)
    {
    }

    protected void RegisterProjBuildAll<TData>(
        string scriptfileName
        , string project)
            where TData : ICodeData
    {
        Container.RegisterSingleton<IProjBuildAll, ProjBuildAllScript>(
            $"{project}BuildAllScript"
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(ResetingProjExtractor))
                , Container.Resolve<ICodeData>(typeof(TData).Name)
                , new ProjBuildAllDTO(scriptfileName, project)));
    }
}