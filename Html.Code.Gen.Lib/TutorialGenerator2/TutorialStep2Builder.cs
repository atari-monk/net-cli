namespace Html.Code.Gen.Lib.TutorialGenerator2;

public class TutorialStep2Builder : TutorialStep2
{
  public string GetBlock1()
  {
    return $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
    </li>{Environment.NewLine}
    """;
  }

  public string GetBlock2()
  {
    return $"""
    {(IsAsideNeeded() ? GetAside() : string.Empty)}
    """.TrimEnd();
  }

  public string GetBlock3()
  {
    return $"""
    {GetDetails()}
    """;
  }

  public string GetBlock4()
  {
    return $"""
    {GetCodes()}
    """;
  }

  public string GetBlock12()
  {
    return $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
      {(IsAsideNeeded() ? GetAside() : string.Empty).TrimEnd()}
    </li>
    """;
  }

  public string GetBlock123()
  {
    return $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
      {(IsAsideNeeded() ? GetAsideWithDetails() : string.Empty).TrimEnd()}
    </li>
    """;
  }

  public string GetBlock1234()
  {
    return $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
      {(IsAsideNeeded() ? GetAsideWithDetails() : string.Empty).TrimEnd()}
      {GetCodes()}
    </li>
    """;
  }
}
