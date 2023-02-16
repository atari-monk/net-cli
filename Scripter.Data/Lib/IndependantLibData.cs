using Scripter.Data.Helper;

namespace Scripter.Data;

public class IndependantLibData 
    : CodeData
{
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    protected ProjectDTO? Vector2;
    protected ProjectDTO? XmlGenerator;
    protected ProjectDTO? XUnitHelper;
    
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 7, 16);
        DIHelper = SetProjAndTests(
            "di-helper"
            , "DIHelper"
            , SetTest("DIHelper.Tests"));
        DotNetExtension = SetProjAndTests(
            "dotnet-extension"
            , "DotNetExtension"
            , SetTest("DotNetExtension.Tests"));
        DotNetTool = Set(
            "dotnet-tool"
            , "DotNetTool");
        Vector2 = SetProjAndTests(
            "vector-lib"
            , "Vector.Lib"
            , SetTest("Vector.Lib.Tests"));
        XmlGenerator = SetProjAndTests(
            "xml-generator"
            , "Xml.Generator"
            , SetTest("Xml.Generator.Tests"));
        var wpfHelper = Set(
            "wpf-helper"
            , "WpfHelper"
            , isApp: false
            , isWpf: false);
        var unityTests = SetProjAndTests(
            "unitycontainer-examples"
            , "UnityContainer.Tests"
            , SetTest("UnityContainer.Tests"));
        var pattern = Set(
            "pattern"
            , "Pattern");
        var netExamples = SetProjAndTests(
            "dotnet-examples"
            , "Net.Examples"
            , SetTest("Net.Tests"));
        XUnitHelper = SetProjAndTests(
            "xunit-helper"
            , "XUnit.Helper"
            , SetTest("XUnit.Helper"));
    }
}