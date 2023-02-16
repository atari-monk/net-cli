using Scripter.Data.Helper;

namespace Scripter.Data;

public class ModernMDILogData 
    : LogLibData
{
    private ProjectDTO? modernMDICLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetMDIHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernMDICLIApp = Set(
            "log-modern-mdi-consoleapp"
            , "Log.Modern.MDI.ConsoleApp"
            , isApp: true
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetMDIHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , Data
            , Tables
            , ModernLibCmds);
    }
}