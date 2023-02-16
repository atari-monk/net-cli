namespace Scripter.Lib;

public class DefaultProjScriptSequence
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
            , JoinableScripts.CopyBuild
            , JoinableScripts.VersionFile
            , JoinableScripts.Build
        };
    }
}