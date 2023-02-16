using CommandDotNet;
using Html.Code.Gen.Lib.TutorialGenerator;

public class TutorialScheme
{
  [DefaultCommand]
  public void Execute()
  {
    var dataJson = new TutorialSerizalizer();
    dataJson.GetJsonFromTestList();
  }
}