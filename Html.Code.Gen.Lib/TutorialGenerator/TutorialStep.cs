using System.Text;

namespace Html.Code.Gen.Lib.TutorialGenerator;

public class TutorialStep
{
  public string? Title { get; set; }
  public CodeElement[]? Codes { get; set; }

  public string GetHtml()
  {
    var isAsideNeeded = IsAsideNeeded();
    var html = new StringBuilder();
    html.AppendLine("<li>");
    html.AppendLine("    <p>");
    html.AppendLine($"        {Title}");
    html.AppendLine("    </p>");
    if (isAsideNeeded)
    {
      html.AppendLine("    <aside>");
      html.AppendLine("        <details>");
      html.AppendLine("            <summary>details</summary>");
      if (Codes != null)
        foreach (var code in Codes)
        {
          html.Append(code.GetParamDescs());
        }
      html.AppendLine("        </details>");
      html.AppendLine("    </aside>");
    }
    html.AppendLine("    <p>");
    if (Codes != null)
      foreach (var code in Codes)
      {
        html.AppendLine($"        <button class='btn-copy' onclick=\"Copy('code{code.Nr}')\"></button>");
        html.Append(code.GetCodeHtml());
      }
    html.AppendLine("    </p>");
    html.AppendLine("</li>");
    return html.ToString();
  }

  private bool IsAsideNeeded()
  {
    var result = false;
    if (Codes != null && Codes.Length > 0)
    {
      foreach (var code in Codes)
      {
        if (code.CodeParams != null && code.CodeParams.Length > 0)
        {
          result = true;
          break;
        }
      }
    }
    return result;
  }
}