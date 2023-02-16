using System.Text;
using Html.Code.Gen.Lib.TutorialGenerator;

namespace Html.Code.Gen.Lib.TestData;

public static class DataSetA1
{
  public static TutorialStep GetData() => DataSetA.GetData();

  public static string GetExpected()
  {
    var e = new StringBuilder();
    e.Add("<li>")
    .Add("    <p>")
    .Add("        Create resource group")
    .Add("    </p>")
    .Add("    <aside>")
    .Add("        <details>")
    .Add("            <summary>details</summary>")
    .Add("            <p><mark class=\"mark-resource-group\">choose your resource group name</mark></p>")
    .Add("            <p><mark class=\"mark-location\">choose your location</mark></p>")
    .Add("        </details>")
    .Add("    </aside>")
    .Add("    <p>")
    .Add($"        <button class='btn-copy' onclick=\"Copy('code1')\"></button>")
    .Add($"        <code id='code1'>")
    .Add($"            az group create --name <mark class=\"mark-resource-group\">CommonResourceGroup</mark> --location <mark class=\"mark-location\">swedencentral</mark>")
    .Add("        </code>")
    .Add("        <br>")
    .Add("    </p>")
    .Add("</li>");
    return e.ToString();
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetHtml(), name: "tutorial-generator-set-a1");
  }
}