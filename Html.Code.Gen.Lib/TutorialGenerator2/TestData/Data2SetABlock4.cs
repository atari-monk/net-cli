using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetABlock4
{
  public static TutorialStep2Builder GetData() => Data2SetA.GetData();

  public static string GetExpected()
  {
    return $"""
    <button class='btn-copy' onclick="Copy('code1')"></button>
      <code id='code1'>
        az group create --name <mark class="mark-resource-group">CommonResourceGroup</mark> --location <mark class="mark-location">swedencentral</mark>
      </code>
      <br>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetBlock4(), name: "tutorial-generator2-set-a-block4");
  }
}
