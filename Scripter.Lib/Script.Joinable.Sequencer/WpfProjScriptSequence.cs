namespace Scripter.Lib;

public class WpfProjScriptSequence
    : JoinableScriptSequencerBase
{
    public override JoinableScripts[] GetProjScriptSequence()
    {
        return new JoinableScripts[]
        {
            JoinableScripts.Clone
            , JoinableScripts.Pull
            , JoinableScripts.Test
            , JoinableScripts.Compile
            , JoinableScripts.CopyBuildWpf
            , JoinableScripts.VersionFile
            , JoinableScripts.Build
        };
    }
}