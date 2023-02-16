using System.Text;

namespace Html.Code.Gen.Lib.TutorialGenerator2;

public class CodeElement2
{
  public int Nr { get; set; }
  public string? CodeFormat { get; set; }
  public CodeParam2[]? CodeParams { get; set; }

  public string GetParamDescs()
  {
    var sb = new StringBuilder();
    if (CodeParams != null)
      foreach (var param in CodeParams)
      {
        sb.AppendLine(param.GetParamDescHtml());
      }
    return sb.ToString().TrimEnd();
  }

  public string GetCodeHtml()
  {
    return $"""
      <code id='code{Nr}'>
        {GetCodeWithMarkedParams()}
      </code>
      <br>
    """;
  }

  private string GetCodeWithMarkedParams()
  {
    if (CodeParams != null && string.IsNullOrWhiteSpace(CodeFormat) == false)
    {
      var names = new List<string>();
      foreach (var param in CodeParams)
      {
        names.Add(param.GetMarkedNameHtml());
      }
      return string.Format(CodeFormat, names.ToArray());
    }
    return CodeFormat ?? "";
  }
}