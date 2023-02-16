using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetABlock123
{
  public static TutorialStep2Builder GetData() => Data2SetA.GetData();

  public static string GetExpected()
  {
    return """
    <li>
      <p>
        Create resource group
      </p>
      <aside>
        <details>
          <summary>details</summary>
          <p><mark class="mark-resource-group">choose your resource group name</mark></p>
          <p><mark class="mark-location">choose your location</mark></p>
        </details>
      </aside>
    </li>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetBlock123(), name: "tutorial-generator2-set-a-block123");
  }
}