using Scripter.Data.Helper;

namespace Scripter.Data;

public class TwoRefLibData 
    : OneRefLibData
{
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? DataToTable;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        CLIReader = SetProjectDepsAndTests(
            "cli-reader"
            , "CLIReader"
            , SetTests("CLIReader.Tests")
            , DIHelper
            , CLIHelper
            );
        DataToTable = SetProjectDepsAndTests(
            "datatotable"
            , "DataToTable"
            , SetTests("DataToTable.Tests")
            , DIHelper
            , ModelHelper
            );
    }
}