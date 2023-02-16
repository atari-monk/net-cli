using System.Windows.Input;
using CommandDotNet;

namespace Scripter;

[Command("script")]
public class ScriptCommands
{
    private readonly ICommand scriptCommand;

    public ScriptCommands(
        ICommand scriptCommand)
    {
        this.scriptCommand = scriptCommand;

        ArgumentNullException.ThrowIfNull(this.scriptCommand);
    }

    [DefaultCommand()]
    public void Script()
    {
        scriptCommand.Execute(default);
    }
}