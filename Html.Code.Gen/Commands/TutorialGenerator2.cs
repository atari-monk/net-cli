using CommandDotNet;
using Html.Code.Gen.Lib;
using Html.Code.Gen.Lib.TutorialGenerator;

public class TutorialGenerator2
{
  private IHtmlGenerator generator;

  public TutorialGenerator2()
  {
    generator = new TutorialsGenerator2();
  }

  [DefaultCommand]
  public void Execute()
  {
    generator.GenerateHtmlFiles();
  }
}