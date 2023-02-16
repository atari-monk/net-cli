using CommandDotNet;
using Html.Code.Gen.Lib.Serialize;

public class PathScheme
{
  [DefaultCommand]
  public void Execute()
  {
    var filesScheme = new FilesSerizalizer();
    filesScheme.SerializeSchema();
  }
}