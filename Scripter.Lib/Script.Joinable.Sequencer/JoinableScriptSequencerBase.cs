namespace Scripter.Lib;

public abstract class JoinableScriptSequencerBase
    : IJoinableScriptSequencer
{
    public abstract JoinableScripts[] GetProjScriptSequence();
}