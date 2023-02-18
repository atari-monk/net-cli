using CommandDotNet;
using CommandDotNet.Unity.Helper;
using Config.Wrapper;
using Serilog;

namespace Modern.CLI.App.Template;

public class ReplCli 
    : AppProgUnity<ReplCli>
{
    [Subcommand]
    public AppCommands? AppCommands { get; set; }

    public ReplCli(
        ILogger log
        , IConfigReader config) 
            : base(log, config)
    {
    }
}