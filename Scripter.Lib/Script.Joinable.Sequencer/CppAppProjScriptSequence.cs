namespace Scripter.Lib;

public class CppAppProjScriptSequence
    : JoinableScriptSequencerBase
{
    public override JoinableScripts[] GetProjScriptSequence()
    {
        return new JoinableScripts[]
        {
            JoinableScripts.Clone
            , JoinableScripts.Pull
            , JoinableScripts.Test
            , JoinableScripts.CompileCpp
            , JoinableScripts.CopyBuildCpp
            , JoinableScripts.CopyApp
            , JoinableScripts.VersionFile
            , JoinableScripts.BuildApp
        };
    }
}