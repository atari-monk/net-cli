using System.ComponentModel.DataAnnotations;
using CommandDotNet;

namespace Refactor.App;

public class FileArgs
    : IArgumentModel
{
    [Operand(nameof(FilePath)), Required, MaxLength(260)]
    public string? FilePath { get; set; }
}

public class FileArgs2
    : IArgumentModel
{
  [Operand(nameof(In)), Required, MaxLength(260)]
  public string? In { get; set; }

  [Operand(nameof(Out)), Required, MaxLength(260)]
  public string? Out { get; set; }
}