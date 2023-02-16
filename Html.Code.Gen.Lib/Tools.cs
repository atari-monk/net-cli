using System.Text;

namespace Html.Code.Gen.Lib;

static class Tools {
  public static void SaveAsHtml(string expected, string actual, string name)
  {
    File.WriteAllText($@"{Config.HtmlFolder}\expected-{name}.html", expected);
    File.WriteAllText($@"{Config.HtmlFolder}\actual-{name}.html", actual);
  }

  public static StringBuilder Add(this StringBuilder sb, string l)
  {
    sb.AppendLine(l);
    return sb;
  }
}