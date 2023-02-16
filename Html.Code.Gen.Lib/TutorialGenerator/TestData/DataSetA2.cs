using Html.Code.Gen.Lib.TutorialGenerator;

namespace Html.Code.Gen.Lib.TestData;

public static class DataSetA2
{
  public static TutorialStep GetData() => DataSetA.GetData();

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
      <p>
        <button class='btn-copy' onclick="Copy('code1')"></button>
        <code id='code1'>
                az group create --name <mark class="mark-resource-group">CommonResourceGroup</mark> --location <mark class="mark-location">swedencentral</mark>
            </code>
        <br>
      </p>
    </li>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetHtml(), name: "tutorial-generator-set-a2");
  }
}