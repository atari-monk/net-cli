using DIHelper;
using Unity;

namespace Scripter.Lib.Tests;

public class LibsListFixture
{
    public IProjectList CodeData { get; private set; }

    public LibsListFixture()
    {
        var unity = new UnityContainer();
        var setA = new ProjectListSetA(unity);
        var sets = new IDependencySet[]
        {
            new CodeDataSet(unity)
            , setA
        };
        foreach (var set in sets)
        {
            set.Register();
        }
        CodeData = setA.Resolve<IProjectList>(nameof(LibsList));
    }
}