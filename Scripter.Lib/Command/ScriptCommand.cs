using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    private readonly IDictionary<ScriptWriters, IScriptWriter> writerStore;

    public event EventHandler? CanExecuteChanged;

    public ScriptCommand(IDictionary<ScriptWriters, IScriptWriter> writerStore)
    {
        this.writerStore = writerStore;
    }

    public void Invalidate()
    {
        CanExecuteChanged?.BeginInvoke(this, new EventArgs(), null, null);
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        writerStore[ScriptWriters.JoinableScript].WriteScripts();
        writerStore[ScriptWriters.ProjectBuildAll].WriteScripts();
        writerStore[ScriptWriters.BuildAll].WriteScripts();
    }
}