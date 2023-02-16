using CommandDotNet;

public class Program
{
  static int Main(string[] args)
  {
    return new AppRunner<Program>().Run(args);
  }

  [Subcommand]
  public TableGenerator? TableGenerator { get; set; }

  [Subcommand]
  public InsertGenerator? InsertGenerator { get; set; }

  [Subcommand]
  public TestFiles? TestFiles { get; set; }

  [Subcommand]
  public TutorialScheme? TutorialScheme { get; set; }

  [Subcommand]
  public PathScheme? PathScheme { get; set; }

  [Subcommand]
  public TutorialGenerator? TutorialGenerator { get; set; }

  [Subcommand]
  public TutorialGenerator2? TutorialGenerator2 { get; set; }
}