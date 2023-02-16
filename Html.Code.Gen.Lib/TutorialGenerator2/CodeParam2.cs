namespace Html.Code.Gen.Lib.TutorialGenerator2;

public class CodeParam2
{
  public string? Name { get; set; }
  public string? Desc { get; set; }
  public string? CssClass { get; set; }

  public string GetParamDescHtml()
  {
    return $"      <p><mark class=\"{CssClass}\">{Desc}</mark></p>";
  }

  public string GetMarkedNameHtml()
  {
    return $"<mark class=\"{CssClass}\">{Name}</mark>";
  }
}