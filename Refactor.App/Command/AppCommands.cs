using CommandDotNet;

namespace Refactor.App;

[Command("edit")]
public class AppCommands
{
  [Command("lambdatobrackets")]
  public async void ConvertLambdaToBrackets(FileArgs model)
  {
    Console.WriteLine($"FilePath: {model.FilePath}");
    if (string.IsNullOrWhiteSpace(model.FilePath))
      throw new ArgumentException(nameof(model.FilePath));
    var text = await File.ReadAllLinesAsync(model.FilePath);
    var lines = text.ToList();
    var line = lines.FirstOrDefault(l => l.Contains("() =>"));
    if (string.IsNullOrWhiteSpace(line))
      throw new ArgumentException(nameof(line));
    var lineIndex = lines.IndexOf(line);
    Console.WriteLine($"FoundLine: {text[lineIndex]}");
    var lineToRefactor = lines[lineIndex];
    var split = lineToRefactor.Split("() =>");
    var methodName = split[0];
    var methodBody = split[1];
    Console.WriteLine("RefactoredLine:");
    Console.WriteLine(lines[lineIndex]);
    lines.RemoveAt(lineIndex);
    lines.Insert(lineIndex, "\t}");
    lines.Insert(lineIndex, "\t\t" + methodBody.Trim());
    lines.Insert(lineIndex, "\t{");
    lines.Insert(lineIndex, $"{methodName}()");
    await File.WriteAllLinesAsync(model.FilePath, lines);
  }

  //having lineN add "lineN",
  [Command("texttojson")]
  public async void AppInfo(FileArgs2 model)
  {
    Console.WriteLine($"FilePath: {model.In}");
    if (string.IsNullOrWhiteSpace(model.In))
      throw new ArgumentException(nameof(model.In));
    var text = await File.ReadAllLinesAsync(model.In);
    var lines = text.ToList();
    for (int i = 0; i < lines.Count; i++)
    {
      lines[i] = lines[i].Trim();
      if (IsLineAText(lines, i) && IsNextLineAText(lines, i))
        lines[i] = string.Format("\"{0}\",", lines[i].Trim());
      else if(IsLineAText(lines, i) && IsNextLineAText(lines, i) == false)
        lines[i] = string.Format("\"{0}\"", lines[i].Trim());
    }
    ArgumentNullException.ThrowIfNull(model.Out);
    await File.WriteAllLinesAsync(model.Out, lines);
  }

  private static bool IsLineAText(List<string> lines, int i)
  {
    return string.IsNullOrWhiteSpace(lines[i]) == false;
  }

  private static bool IsNextLineAText(List<string> lines, int i)
  {
    return i+1 < lines.Count ? 
      string.IsNullOrWhiteSpace(lines[i+1]) == false
      : false;
  }
}