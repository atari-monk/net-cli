namespace Scripter.Lib.Tests;

public abstract class ProjListTestBase
{
    public abstract void TestListContent(
        int index
        , string expected);

    protected static string GetItem(
        IProjectList list
        , int index)
    {
        return list.Projects[index].ProjFolder;
    }
}