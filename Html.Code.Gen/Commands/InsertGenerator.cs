using CommandDotNet;
using Html.Code.Gen.Lib;
using InsertGen = Html.Code.Gen.Lib.InsertGenerator;

public class InsertGenerator
{
  [DefaultCommand]
  public async Task ExecuteAsync()
  {
    IHtmlGeneratorAsync g1 = new InsertGen(@"C:\atari-monk\Code\sql\Task1\person.txt", 4);
    await g1.GenerateHtmlFilesAsync();
    IHtmlGeneratorAsync g2 = new InsertGen(@"C:\atari-monk\Code\sql\Task1\address.txt", 5);
    await g2.GenerateHtmlFilesAsync();
  }
}