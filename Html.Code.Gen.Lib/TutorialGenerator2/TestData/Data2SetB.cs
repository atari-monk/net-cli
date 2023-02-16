using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetB
{
  public static TutorialStep2Builder GetData() =>
    new TutorialStep2Builder
    {
      Title = "Create resource group",
      Codes = new CodeElement2[] {
        new CodeElement2
        {
          Nr = 1,
          CodeFormat = "az group create"
        },
        new CodeElement2
        {
          Nr = 2,
          CodeFormat = "az group create"
        }
      }
    };

  public static string GetExpected()
  {
    return $"""
    <li>
      <p>
        Create resource group
      </p>
      <button class='btn-copy' onclick="Copy('code1')"></button>
      <code id='code1'>
        az group create
      </code>
      <br>
      <button class='btn-copy' onclick="Copy('code2')"></button>
      <code id='code2'>
        az group create
      </code>
      <br>
    </li>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetStep(), name: "tutorial-generator2-set-b");
  }
}
