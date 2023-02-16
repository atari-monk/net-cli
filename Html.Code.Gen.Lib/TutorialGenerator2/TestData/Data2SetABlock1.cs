using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetABlock1
{
  public static TutorialStep2Builder GetData() => Data2SetA.GetData();

  public static string GetExpected()
  {
    var title = "Create resource group";
    return $"""
    <li>
      <p>
        {title}
      </p>
    </li>{Environment.NewLine}
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetBlock1(), name: "tutorial-generator2-set-a-block1");
  }
}