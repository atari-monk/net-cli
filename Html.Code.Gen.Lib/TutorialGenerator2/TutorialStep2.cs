using System.Text;

namespace Html.Code.Gen.Lib.TutorialGenerator2;

public class TutorialStep2 : ITutorialStep2
{
  public string? Title { get; set; }
  public CodeElement2[]? Codes { get; set; }

  public string GetHtml(List<TutorialStep2> data)
  {
    return $"""
    <!DOCTYPE html>
    <html lang="en">

    <head>
      <meta charset="UTF-8">
      <meta name="author" content="atari-monk">
      <meta name="description" content="Page of my tech wiki.">
      <title>Tech Wiki Web Page</title>
      <link rel="icon" href="../../img/html5.png" type="image/x-icon">
      <link rel="stylesheet" href="../../css/mobile.css" type="text/css">
      <link rel="stylesheet" href="../../css/main.css" type="text/css">
      <script type="module" src="../../js/script.js"></script>
    </head>

    <body>
      <header>
        <h1 class="title">Title</h1>
        <nav aria-label="primary-navigation">
          <ul>
            <li>
              <a id="main-css" href="#">Main</a>
              <a id="mobile-css" href="#">Mobile</a>
            </li>
            <li class="list-point">
              <a href="#notes">Notes</a>
            </li>
          </ul>
        </nav>
      </header>
      <hr>
      <main>
        <article id="notes">
          <h2>Notes</h2>
          <ol>
            {GetSteps(data)}
          </ol>
        </article>
      </main>
      <hr>
      <footer>
        <p class="desc">
          &lt;&lt;&lt;
          <a href="https://github.com/atari-monk">atari-monk</a>
          &gt;&gt;&gt;
        </p>
        <p class="desc">
          <a href="#">Back to Top</a>
        </p>
      </footer>
    </body>

    </html>
    """;
  }

  public string GetSteps(List<TutorialStep2> data)
  {
    var sb = new StringBuilder();
    foreach (var item in data)
    {
      sb.AppendLine(item.GetStep());
    }
    return sb.ToString().TrimEnd();
  }

  public string GetStep()
  {
    var aside = $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
      {GetAsideWithDetails()}
      {GetCodes()}
    </li>
    """;
    var noAside = $"""
    <li>
      <p>
        {Title?.Trim()}
      </p>
      {GetCodes()}
    </li>
    """;
    return IsAsideNeeded() ? aside : noAside;
  }

  protected bool IsAsideNeeded()
  {
    if (Codes == null || Codes.Length == 0) return false;
    foreach (var _ in from code in Codes
                      where code.CodeParams != null && code.CodeParams.Length > 0
                      select new { })
    {
      return true;
    }
    return false;
  }

  protected string GetAside()
  {
    return $"""
    <aside>
        <details>
          <summary>details</summary>
        </details>
      </aside>
    """;
  }

  protected string GetAsideWithDetails()
  {
    return $"""
    <aside>
        <details>
          <summary>details</summary>
    {GetDetails()}
        </details>
      </aside>
    """;
  }

  protected string GetDetails()
  {
    if (Codes == null) return string.Empty;
    var sb = new StringBuilder();
    foreach (var code in Codes)
    {
      sb.Append(code.GetParamDescs());
    }
    return sb.ToString().TrimEnd();
  }

  protected string GetCodes()
  {
    if (Codes == null) return string.Empty;
    var sb = new StringBuilder();
    var i = 0;
    foreach (var code in Codes)
    {
      sb.AppendLine(i > 0 ? $"  <button class='btn-copy' onclick=\"Copy('code{code.Nr}')\"></button>" : $"<button class='btn-copy' onclick=\"Copy('code{code.Nr}')\"></button>");
      sb.AppendLine(code.GetCodeHtml());
      i++;
    }
    return sb.ToString().TrimEnd();
  }


}