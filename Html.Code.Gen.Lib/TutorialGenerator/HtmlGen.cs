using System.Text;
using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TutorialGenerator;

public class HtmlGen
{
  public string GetHtml(List<TutorialStep> data)
  {
    var sb = new StringBuilder();
    foreach (var item in data)
    {
      sb.Append(item.GetHtml());
    }
    return sb.ToString();
  }
}