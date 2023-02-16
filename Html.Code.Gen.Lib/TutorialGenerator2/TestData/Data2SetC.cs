using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetC
{
  public static List<TutorialStep2> GetData() =>
    new List<TutorialStep2>
    {
      new TutorialStep2 {
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
      }},
      new TutorialStep2 {
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
      }}
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

  public static string GetActual()
  {
    return new TutorialStep2().GetHtml(GetData());
  }

  public static string GetActualNotes()
  {
    return new TutorialStep2().GetSteps(GetData());
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetActualNotes(), name: "tutorial-generator2-set-c");
  }
}
