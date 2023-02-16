namespace Scripter.Lib;

public class WpfAppProjScriptSequence
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
            , JoinableScripts.CopyApp
            , JoinableScripts.VersionFile
            , JoinableScripts.BuildApp
        };
    }
}