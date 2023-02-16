using CommandDotNet;

namespace Modern.CLI.App.Template;

[Command("app")]
public class AppCommands
{
    [DefaultCommand()]
    public void AppInfo()
    {
        Console.WriteLine("App template :)");
    }
}