using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetABlock2
{
  public static TutorialStep2Builder GetData() => Data2SetA.GetData();

  public static string GetExpected()
  {
    return """
    <aside>
        <details>
          <summary>details</summary>
        </details>
      </aside>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetBlock2(), name: "tutorial-generator2-set-a-block2");
  }
}
