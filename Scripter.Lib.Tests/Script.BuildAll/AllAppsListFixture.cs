using DIHelper;
using Unity;

namespace Scripter.Lib.Tests;

public class AllAppsListFixture
{
    public IProjectList CodeData { get; private set; }

    public AllAppsListFixture()
    {
        var unity = new UnityContainer();
        var setB = new ProjectListSetB(unity);
        var sets = new IDependencySet[]
        {
            new CodeDataSet(unity)
            , new CodeDataDictionarySet(unity)
            , new ProjectListSetA(unity)
            , setB
        };
        foreach (var set in sets)
        {
            set.Register();
        }
        CodeData = setB.Resolve<IProjectList>(nameof(AllAppsList));
    }
}