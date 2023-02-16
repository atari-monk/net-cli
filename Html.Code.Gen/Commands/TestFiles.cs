using CommandDotNet;
using Html.Code.Gen.Lib.TestData;

public class TestFiles
{
  [DefaultCommand]
  public void Execute()
  {
    SaveAsHtmlAll(isOn: true);
  }

  private static void SaveAsHtmlAll(bool isOn = false)
  {
    if (isOn == false) return;
    DataSetA1.SaveAsHtml();
    DataSetA2.SaveAsHtml();
    DataSetB.SaveAsHtml();
    Data2SetABlock1.SaveAsHtml();
    Data2SetABlock2.SaveAsHtml();
    Data2SetABlock3.SaveAsHtml();
    Data2SetABlock4.SaveAsHtml();
    Data2SetABlock12.SaveAsHtml();
    Data2SetABlock123.SaveAsHtml();
    Data2SetABlock1234.SaveAsHtml();
    Data2SetA.SaveAsHtml();
    Data2SetB.SaveAsHtml();
    Data2SetC.SaveAsHtml();
  }
}