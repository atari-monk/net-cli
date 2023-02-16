using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TestData;

public static class Data2SetA
{
  public static TutorialStep2Builder GetData() =>
    new TutorialStep2Builder
    {
      Title = "Create resource group",
      Codes = new CodeElement2[] {
        new CodeElement2
        {
          Nr = 1,
          CodeFormat = "az group create --name {0} --location {1}",
          CodeParams = new CodeParam2[] {
            new CodeParam2 {
              Name = "CommonResourceGroup"
              , Desc = "choose your resource group name"
              , CssClass = "mark-resource-group"
            },
            new CodeParam2 {
              Name = "swedencentral"
              , Desc = "choose your location"
              , CssClass = "mark-location"
            }
          }
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
      <aside>
        <details>
          <summary>details</summary>
          <p><mark class="mark-resource-group">choose your resource group name</mark></p>
          <p><mark class="mark-location">choose your location</mark></p>
        </details>
      </aside>
      <button class='btn-copy' onclick="Copy('code1')"></button>
      <code id='code1'>
        az group create --name <mark class="mark-resource-group">CommonResourceGroup</mark> --location <mark class="mark-location">swedencentral</mark>
      </code>
      <br>
    </li>
    """;
  }

  public static void SaveAsHtml()
  {
    Tools.SaveAsHtml(GetExpected(), GetData().GetStep(), name: "tutorial-generator2-set-a");
  }
}
