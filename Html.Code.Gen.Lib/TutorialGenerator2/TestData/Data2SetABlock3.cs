using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetABlock3
{
  public static TutorialStep2Builder GetData() => Data2SetA.GetData();

  public static string GetExpected()
  {
    return $"""
          <p><mark class="mark-resource-group">choose your resource group name</mark></p>
          <p><mark class="mark-location">choose your location</mark></p>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetBlock3(), name: "tutorial-generator2-set-a-block3");
  }
}
