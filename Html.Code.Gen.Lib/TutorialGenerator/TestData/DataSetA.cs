using Html.Code.Gen.Lib.TutorialGenerator;

namespace Html.Code.Gen.Lib.TestData;

public static class DataSetA
{
  public static TutorialStep GetData() =>
    new TutorialStep
    {
      Title = "Create resource group",
      Codes = new CodeElement[] {
        new CodeElement
        {
          Nr = 1,
          CodeFormat = "az group create --name {0} --location {1}",
          CodeParams = new CodeParam[] {
            new CodeParam {
              Name = "CommonResourceGroup"
              , Desc = "choose your resource group name"
              , CssClass = "mark-resource-group"
            },
            new CodeParam {
              Name = "swedencentral"
              , Desc = "choose your location"
              , CssClass = "mark-location"
            }
          }
        }
      }
    };
}
