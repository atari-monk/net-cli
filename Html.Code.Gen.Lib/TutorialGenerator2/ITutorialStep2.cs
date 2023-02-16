namespace Html.Code.Gen.Lib.TutorialGenerator2;

public interface ITutorialStep2
{
  string? Title { get; set; }
  CodeElement2[]? Codes { get; set; }

  string GetHtml(List<TutorialStep2> data);
}
