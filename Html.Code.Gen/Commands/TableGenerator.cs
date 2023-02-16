using CommandDotNet;
using Html.Code.Gen.Lib;
using TableGen = Html.Code.Gen.Lib.TableGenerator;

public class TableGenerator
{
  [DefaultCommand]
  public async Task ExecuteAsync()
  {
    IHtmlGeneratorAsync g1 = new TableGen(@"C:\atari-monk\Code\sql\Task1\person.txt");
    await g1.GenerateHtmlFilesAsync();
    IHtmlGeneratorAsync g2 = new TableGen(@"C:\atari-monk\Code\sql\Task1\address.txt");
    await g2.GenerateHtmlFilesAsync();
    IHtmlGeneratorAsync g3 = new TableGen(@"C:\atari-monk\Code\sql\Task1\address-type.txt");
    await g3.GenerateHtmlFilesAsync();
  }
}