namespace Scripter;

public interface IScript
{
    string File { get; }

    string[] GetScript();
}