using System.Text;
using Html.Code.Gen.Lib.TutorialGenerator;

namespace Html.Code.Gen.Lib.TestData;

public static class DataSetB
{
  public static TutorialStep GetData() =>
    new TutorialStep
    {
      Title = "Run locally",
      Codes = new CodeElement[] {
          new CodeElement{
            Nr = 1,
            CodeFormat = "docker-compose up --build -d"
          },
          new CodeElement{
            Nr = 2,
            CodeFormat = "docker images"
          },
          new CodeElement{
            Nr = 3,
            CodeFormat = "docker ps"
          },
        }
    };

  public static string GetExpected()
  {
    var e = new StringBuilder();
    e.Add("<li>")
     .Add("    <p>")
     .Add("        Run locally")
     .Add("    </p>")
     .Add("    <p>")
     .Add($"        <button class='btn-copy' onclick=\"Copy('code1')\"></button>")
     .Add($"        <code id='code1'>")
     .Add($"            docker-compose up --build -d")
     .Add("        </code>")
     .Add("        <br>")
     .Add($"        <button class='btn-copy' onclick=\"Copy('code2')\"></button>")
     .Add($"        <code id='code2'>")
     .Add($"            docker images")
     .Add("        </code>")
     .Add("        <br>")
     .Add($"        <button class='btn-copy' onclick=\"Copy('code3')\"></button>")
     .Add($"        <code id='code3'>")
     .Add($"            docker ps")
     .Add("        </code>")
     .Add("        <br>")
     .Add("    </p>")
     .Add("</li>");
    return e.ToString();
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetHtml(), name: "tutorial-generator-set-b");
  }
}