using CommandDotNet;
using Html.Code.Gen.Lib;
using Html.Code.Gen.Lib.TutorialGenerator;

public class TutorialGenerator
{
  private IHtmlGenerator generator;

  public TutorialGenerator()
  {
    generator = new TutorialsGenerator();
  }

  [DefaultCommand]
  public void Execute()
  {
    generator.GenerateHtmlFiles();
  }
}
